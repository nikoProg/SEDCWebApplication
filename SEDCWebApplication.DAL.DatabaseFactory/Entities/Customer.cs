using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SEDCWebApplication.DAL.DatabaseFactory.Entities
{
    public class Customer : User
    {

        public string Name { get; set; }
        //public string Phone { get; set; }

        public string? Email { get; set; } //username u bazi, mapirano u automapper profile

        public string? Address { get; set; }

    }
}
