using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SEDCWebApplication.DAL.DatabaseFactory.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }//zasto je sam odlucio da je name NOT NULL?!
        public decimal UnitPrice { get; set; }
        public bool? IsDiscounted { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        
        //public enum Size { get; set; }
        public string Size { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }

    }
}
