using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SEDCWebApplication.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ime je obavezno")]
        public string Name { get; set; }
        public string Phone { get; set; }

    }
}
