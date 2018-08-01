using MySql.Data.MySqlClient;
using System;
using Microsoft.EntityFrameworkCore;
using CoreSRTModels;
using System.Threading.Tasks;

namespace CoreSRTRepository
{
    public class BillingContext: DbContext, IBillingRepository
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
            modelBuilder.Entity<Item>().HasKey(i => i.ItemId);
            modelBuilder.Entity<Item>().Property(i => i.Description).IsRequired();

           // modelBuilder.Entity<Producer>().HasKey(p => p.ProducerId);
            base.OnModelCreating(modelBuilder);
        }

        public void CreateItem(Item item)
        {
            Items.Add(item);
            SaveChanges();
        }

        public async Task<Item> GetItemAsync(int itemId)
        {
            return await Items.SingleAsync(i => i.ItemId == itemId);
        }
    }
}
