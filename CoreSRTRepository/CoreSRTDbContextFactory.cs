using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CoreSRTRepository
{
    public class CoreSRTDbContextFactory : IDesignTimeDbContextFactory<BillingContext>
    {
        public BillingContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<BillingContext>();
            builder.UseMySql("Server=localhost; userid = root; password = root123; database = test;",
                optionsBuilder => optionsBuilder.MigrationsAssembly(typeof(BillingContext).GetTypeInfo().Assembly.GetName().Name));

            return new BillingContext(builder.Options);
        }
    }
}
