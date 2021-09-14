using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SEDCWebApplication.DAL.Data.Entities
{
    public class Product : BaseEntity
    {
        public Product(int? id)
    : base(id)
        {
        }

        [Required(ErrorMessage = "Ime je obavezno")]//OVO VEROVATNO NE TREBA UNUTAR DAL ENTITY!
        public string Name { get; set; }
        public float? UnitPrice { get; set; }
        public bool? IsDiscounted { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        
        //public enum Size { get; set; }
        public string Size { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }

    }
}
