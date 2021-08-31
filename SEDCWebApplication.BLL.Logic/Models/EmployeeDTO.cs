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

        [Required(ErrorMessage = "Ime je obavezno")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email id is required")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
                    ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }
        public RoleEnum Role { get; set; }

        //public List<Order> Orders { get; set; }

        public string ImagePath { get; set; }

        public bool Test { get; set; }

        public string Gender { get; set; }

        //public int RoleId { get; set; }

        public DateTime DateOfBirth { get; set; }

    }
}