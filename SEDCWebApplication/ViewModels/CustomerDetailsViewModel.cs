using SEDCWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDCWebApplication.ViewModels
{
    public class CustomerDetailsViewModel
    {
        public Customer Customer { get; set; }

        public string PageTitle { get; set; }
    }
}
