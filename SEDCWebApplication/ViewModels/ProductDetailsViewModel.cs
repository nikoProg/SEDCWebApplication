using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDCWebApplication.ViewModels
{
    public class ProductDetailsViewModel
    {
        public string Name { get; set; }
        public float UnitPrice { get; set; }
        public bool IsDiscounted { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        //public enum Size { get; set; }
        public string Size { get; set; }

        //public List<Object> SizeList { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }
    }
}
