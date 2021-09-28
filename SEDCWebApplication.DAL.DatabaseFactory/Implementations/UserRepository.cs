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
    public class UserRepository : IUserDAL
    {
        private IConfiguration Configuration { get; set; }
        public UserRepository(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public User GetUserByUserNameAndPassword(string username, string password)
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlServer(Configuration.GetConnectionString("SEDC2"));
            using (var db = new ApplicationDbContext(optionBuilder.Options))
            {
                User result = db.Users.First(u => u.UserName == username && u.Password == password);
                return result;
            }
        }
    }
}
