using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SEDCWebApplication.DAL.DatabaseFactory.Entities
{
    public class Customer : User
    {
        /*public Customer(int? id)
        : base(id)
        {
        }*/

        [Required(ErrorMessage = "Ime je obavezno")]
        public string Name { get; set; }
        //public string Phone { get; set; }

        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
                            ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; } //username u bazi, mapirano u automapper profile

        public string Address { get; set; }

    }
}
