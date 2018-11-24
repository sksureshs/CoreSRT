using MySql.Data.MySqlClient;
using System;
using Microsoft.EntityFrameworkCore;
using CoreSRTModels;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace CoreSRTRepository
{
    public class BillingContext : DbContext, IBillingRepository
    {

        public BillingContext(DbContextOptions<BillingContext> options) : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillingItem> BillingItems { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<BillingAudit> BillingAudits { get; set; }
        public DbSet<BillingItemAudit> BillingItemAudits { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().ToTable("Items");
            modelBuilder.Entity<Customer>().ToTable("Customers");
            modelBuilder.Entity<Bill>().ToTable("Bills");
            modelBuilder.Entity<BillingItem>().ToTable("BillingItems");

            modelBuilder.Entity<Bill>()
                        .Property(p => p.BillId).ValueGeneratedOnAdd();

            modelBuilder.Entity<BillingItem>()
                        .Property(p => p.BillingItemId).ValueGeneratedOnAdd();

            modelBuilder.Entity<BillingAudit>().ToTable("BillingAudit");

            modelBuilder.Entity<BillingAudit>()
                        .Property(p => p.BillingAutiId).ValueGeneratedOnAdd();

            modelBuilder.Entity<BillingItemAudit>().ToTable("BillingItemAudit");

            modelBuilder.Entity<BillingItemAudit>()
                        .Property(p => p.BillingItemAuditId).ValueGeneratedOnAdd();

            //modelBuilder.Entity<Bill>().HasOne(b => b.Shop).WithOne().HasForeignKey<Customer>(c=>c.CustomerId);

            base.OnModelCreating(modelBuilder);
        }

        public void CreateItem(Item item)
        {
            Items.Add(item);
            SaveChanges();
        }

        public void DeleteItem(int itemId)
        {
            var item = Items.First(i => i.ItemId == itemId);
            if (item == null)
            {
                throw new Exception($"Item {itemId} not present!");
            }

            Items.Remove(item);
            SaveChanges();
        }

        public void UpdateItem(Item item)
        {
            var oldItem = Items.FirstOrDefault(i => i.ItemId == item.ItemId);
            if (oldItem != null)
            {
                oldItem.DateTo = DateTime.Now;

            }
            item.ItemId = 0;
            Items.Add(item);
            SaveChanges();
        }

        public Item GetItem(int itemId)
        {
            return Items.Single(i => i.ItemId == itemId);
        }

        public IEnumerable<Item> GetAllItems()
        {
            var temp = Items.ToListAsync().Result;
            return temp;
        }

        public IEnumerable<Item> GetActiveItems()
        {
            return Items.ToListAsync().Result.Where(i => i.DateTo >= DateTime.Now);
        }

        #region "Customer"
        public void CreateCustomer(Customer customer)
        {
            UpdateCustomerNonNullableProperties(customer);

            Customers.Add(customer);
            SaveChanges();
        }

        public void DeleteCustomer(int customerId)
        {
            var customer = Customers.First(c => c.CustomerId == customerId);

            if (customer == null)
            {
                throw new Exception($"Customer {customerId} not present!");
            }

            Customers.Remove(customer);
            SaveChanges();
        }

        private void UpdateCustomerNonNullableProperties(Customer customer)
        {

            if (string.IsNullOrWhiteSpace(customer.Address))
            {
                customer.Address = "";

            }
            if (string.IsNullOrWhiteSpace(customer.EmailId))
            {
                customer.EmailId = "";
            }

            customer.GSTNo = String.IsNullOrWhiteSpace(customer.GSTNo) ? "" : customer.GSTNo;

            customer.ContactNumber = String.IsNullOrWhiteSpace(customer.ContactNumber) ? "" : customer.ContactNumber;

        }

        public void UpdateCustomer(int customerId, Customer customer)
        {
            var oldCustomer = Customers.Find(customerId);

            if (oldCustomer == null)
            {
                throw new Exception($"Customer {customerId} not present!");
            }

            UpdateCustomerNonNullableProperties(customer);

            oldCustomer.Address = customer.Address;
            oldCustomer.ContactNumber = customer.ContactNumber;
            oldCustomer.EmailId = customer.EmailId;
            oldCustomer.GSTNo = customer.GSTNo;
            oldCustomer.Name = customer.Name;
            oldCustomer.Type = customer.Type;

            SaveChanges();
        }

        public IEnumerable<Customer> GetAllCustomer()
        {
            return Customers.ToListAsync().Result;
        }

        public Customer GetCustomer(int customerId)
        {
            return Customers.First(c => c.CustomerId == customerId);
        }



        #endregion

        #region "Billing"

        public void DeleteBill(int billId)
        {
            var billingItems = BillingItems.Where(b => b.BillId == billId).ToList();

            if (!billingItems.Any())
            {
                BillingItems.RemoveRange(billingItems);
            }

            var bill = Bills.Single(b => b.BillId == billId);
            if (bill == null)
            {
                throw new Exception($"Not able find the bill for billId {billId}");
            }

            Bills.Remove(bill);

            SaveChanges();
        }

        private BillingAudit Map(Bill bill)
        {
            return new BillingAudit
            {
                BillId = bill.BillId,
                CreatedDate = DateTime.Now,
                Date = bill.Date,
                OutStandingAmount = bill.OutStandingAmount,
                ShopCustomerId = bill.ShopCustomerId,
                TotalPrice = bill.TotalPrice,
                TotalQuantity = bill.TotalQuantity
            };
        }

        private BillingItemAudit Map(BillingItem billingItem)
        {
            return new BillingItemAudit
            {
                BillingItemId = billingItem.BillingItemId,
                CGST = billingItem.CGST,
                SGST = billingItem.SGST,
                ItemId = billingItem.ItemId,
                OriginalPrice = billingItem.OriginalPrice,
                SellingPrice = billingItem.SellingPrice,
                Quantity = billingItem.Quantity,
                CreatedDate = DateTime.Now,
                BillId = billingItem.BillId
            };
        }

        public int UpdateBill (Bill bill, IList<BillingItem> billingItems)
        {
            try{
                var oldbill = Bills.Single(b=>b.BillId == bill.BillId);

                if(oldbill == null)
                {
                    throw new Exception("Bill not available");
                }

                BillingAudits.Add(Map(oldbill));
                oldbill.OutStandingAmount = bill.OutStandingAmount;
                oldbill.Date = bill.Date;
                oldbill.UpdatedDate = bill.UpdatedDate;
                oldbill.ShopCustomerId = bill.ShopCustomerId;
                oldbill.TotalPrice = bill.TotalPrice;
                oldbill.TotalQuantity = bill.TotalQuantity;


               // SaveChanges();

                foreach (var newItem in billingItems)
                {
                    var oldItem = BillingItems.FirstOrDefault(bi => bi.BillingItemId == newItem.BillingItemId);
                    var temp = BillingItems.First();

                    if(oldItem == null)
                    {
                        newItem.BillId = oldbill.BillId;
                        newItem.CreatedDate = DateTime.Now;
                        newItem.BillingItemId = 0;
                        BillingItems.Add(newItem);
                        
                    }
                    else
                    {
                        BillingItemAudits.Add(Map(oldItem));
                        oldItem.CGST = newItem.CGST;
                        oldItem.SGST = newItem.SGST;
                        oldItem.ItemId = newItem.ItemId;
                        oldItem.OriginalPrice = newItem.OriginalPrice;
                        oldItem.SellingPrice = newItem.SellingPrice;
                        oldItem.Quantity = newItem.Quantity;
                        oldItem.TotalPrice = newItem.TotalPrice;
                        oldItem.UpdatedDate = DateTime.Now;
                        oldItem.BillId = bill.BillId;
                        //BillingItems.Add(oldItem);
                        
                    }
                }

                SaveChanges();
            }
            catch (Exception ex)
            {
                return 0;
            }

            return bill.BillId;
        }
        public int CreateBill(Bill bill, IList<BillingItem> billingItems)
        {
            try
            {
                bill.CreatedDate = DateTime.Now;
                Bills.Add(bill);
                //SaveChanges();

                foreach (var item in billingItems)
                {
                    //item.BillingItemId = 0;
                    item.CreatedDate = DateTime.Now;
                    
                    item.Bill = bill;
                    item.BillId = bill.BillId;
                    BillingItems.Add(item);
                }

                SaveChanges();

                return bill.BillId;
            }catch(Exception ex)
            {
                throw;
            }
            return 0;
                
        }

        public Bill GetBill(int billNo)
        {
                  var bill =  Bills.First(b => b.BillId == billNo);
            bill.Shop = Customers.Single(c => c.CustomerId == bill.ShopCustomerId);
            return bill;
        }

        public IEnumerable<Bill> GetBills()
        {
            foreach (var bill in Bills)
            {
                if (bill.Shop == null)
                {
                    bill.Shop = Customers.Single(c => c.CustomerId == bill.ShopCustomerId);
                }
                
            }
            return Bills;
        }

        public IEnumerable<BillingItem>GetBillingItems(int billNo)
        {
            var billingItems = BillingItems.Where(b => b.BillId == billNo);
            foreach(var r in billingItems)
            {
                r.Item = Items.Single(i => i.ItemId == r.ItemId);
                r.Bill = Bills.Single(b => b.BillId == r.BillId);
            }
            
            return billingItems;
        }
        #endregion

    }
}
