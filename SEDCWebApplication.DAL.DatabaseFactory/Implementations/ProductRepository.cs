using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SEDCWebApplication.DAL.DatabaseFactory.Entities;
using SEDCWebApplication.DAL.DatabaseFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDCWebApplication.DAL.DatabaseFactory.Implementations
{
    public class ProductRepository : IProductDAL
    {
        private IConfiguration Configuration { get; set; }
        public ProductRepository(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public List<Product> GetAll(int skip, int take)
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlServer(Configuration.GetConnectionString("SEDC2"));
            using (var db = new ApplicationDbContext(optionBuilder.Options))
            {
                List<Product> result = db.Products.Skip(skip).Take(take).ToList();
                return result;
            }
        }

        public Product GetById(int id)
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlServer(Configuration.GetConnectionString("SEDC2"));
            using (var db = new ApplicationDbContext(optionBuilder.Options))
            {
                Product result = db.Products.First(e => e.Id == id);
                /*if (!(result is null))
                {
                    return result;
                }
                else
                {
                    throw Exception
                }*/
                return result;
            }
        }

        public void Save(Product item)
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlServer(Configuration.GetConnectionString("SEDC2"));
            using (var db = new ApplicationDbContext(optionBuilder.Options))
            {
                Product product = new Product();
                db.Products.Add(item);
                db.SaveChanges();
            }
        }

        public void Delete(Product item)
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlServer(Configuration.GetConnectionString("SEDC2"));
            using (var db = new ApplicationDbContext(optionBuilder.Options))
            {
                Product product = new Product();
                db.Products.Update(item);
                item.IsDeleted = true;
                db.SaveChanges();
            }
        }
    }
}
