using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace DataAccessLayer
{
    public class AppContext : DbContext
    {
        public AppContext() : base("name=Online Bill")
        {

        }

        public DbSet<Customers> Customers { get; set; }
        public DbSet<Vendors> Vendors { get; set; }
        public DbSet<CustomerVendor> CustomerVendors { get; set; }
        public DbSet<AccountDetails> AccountDetails { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Transactions> Transactions { get; set; }
        public DbSet<VendorCategory> VendorCategory { get; set; }
        public DbSet<Categories> Categories { get; set; }
    }
}
