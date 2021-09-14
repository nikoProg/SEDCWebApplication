using SEDCWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDCWebApplication.ViewModels
{
    public class CustomerDetailsViewModel
    {
        //public Customer Customer { get; set; }

        //[Required(ErrorMessage = "Ime je obavezno")]
        public string Name { get; set; }
        //public string Phone { get; set; }

        //[RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
        //                    ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; } //username u bazi

        public string ImagePath { get; set; }

        public string PageTitle { get; set; }
    }
}
