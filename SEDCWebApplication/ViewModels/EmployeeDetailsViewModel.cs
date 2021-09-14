using SEDCWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDCWebApplication.ViewModels
{
    public class EmployeeDetailsViewModel
    {
        //public Employee Employee { get; set; }

        public string EmployeeName { get; set; }
        public string PageTitle { get; set; }

        public bool Test { get; set; }

        public string Email { get; set; }

        public string Role { get; set; }

        public string Gender { get; set; }

        //public int RoleId { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string ImagePath { get; set; }
    }
}
