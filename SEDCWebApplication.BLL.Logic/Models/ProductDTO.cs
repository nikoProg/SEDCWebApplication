using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SEDCWebApplication.BLL.Logic.Models
{
    public class ProductDTO
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "Ime je obavezno")]//Ovo mozda ne treba unutar DTO?
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
