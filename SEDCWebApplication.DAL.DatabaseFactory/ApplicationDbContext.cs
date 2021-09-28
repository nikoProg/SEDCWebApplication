using Microsoft.EntityFrameworkCore;
using SEDCWebApplication.DAL.DatabaseFactory.Entities;
using System;

namespace SEDCWebApplication.DAL.DatabaseFactory
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        //public DbSet<Order> Orders { get; set; }

        public DbSet<User> Users { get; set; }

        //public Employee Employee { get; set; }


        public DbSet<Product> Products { get; set; }

        //public Customer Customer { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
