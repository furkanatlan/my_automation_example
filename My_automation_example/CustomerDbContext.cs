using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace My_automation_example
{
    internal class CustomerDbContext:DbContext
    {
        public CustomerDbContext() : base("name=CustomerDbContext")
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CustomerProduct> CustomerProducts { get; set; }


    }
}
