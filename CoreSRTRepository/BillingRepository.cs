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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().ToTable("Items");
            modelBuilder.Entity<Customer>().ToTable("Customers");
            modelBuilder.Entity<Bill>().ToTable("Bills");

            modelBuilder.Entity<Bill>()
                        .Property(p => p.BillId).ValueGeneratedOnAdd();

            modelBuilder.Entity<Bill>().HasOne(b => b.Shop).WithOne().HasForeignKey<Customer>(c=>c.CustomerId);

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
            var temp = Items.ToListAsync().Result.Where(i => i.DateTo >= DateTime.Now);
            return temp;
        }

        #region "Customer"
        public void CreateCustomer(Customer customer)
        {
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

        public void UpdateCustomer(int customerId, Customer customer)
        {
            var oldCustomer = Customers.Find(customerId);
            if (oldCustomer == null)
            {
                throw new Exception($"Customer {customerId} not present!");
            }

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
        public int CreateBill(Bill bill, IList<BillingItem> billingItems)
        {
            Bills.Add(bill);
            foreach(var item in billingItems)
            {
                item.Bill = bill;
                BillingItems.Add(item);
            }
            SaveChanges();

            return bill.BillId;
        }

        public Bill GetBill(int billNo)
        {
            var bill =  Bills.First(b => b.BillId == billNo);
            bill.Shop = Customers.Single(c => c.CustomerId == bill.ShopCustomerId);
            return bill;
        }

        public IEnumerable<BillingItem>GetBillingItems(int billNo)
        {
             var temp = BillingItems.Where(b => b.Bill.BillId == billNo);
            foreach(var r in temp)
            {
                r.Item = Items.Single(i => i.ItemId == r.ItemId);
            }
            
            return temp;
        }
        #endregion

    }
}
