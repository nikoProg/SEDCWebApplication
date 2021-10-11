using SEDCWebApplication.DAL.DatabaseFactory.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SEDCWebApplication.BLL.Logic.Models
{
    public class EmployeeDTO
    {
        public int? Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
        public RoleEnum Role { get; set; }
        //public int RoleId { get; set; }

        public List<Order> Orders { get; set; }

        public string ImagePath { get; set; }

        //public bool Test { get; set; }

        public string Gender { get; set; }


        public DateTime? DateOfBirth { get; set; }

    }
}