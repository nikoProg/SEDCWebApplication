using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SEDCWebApplication.Models
{
    public enum RoleEnum
    {
        [Display(Name="Menadzer")]
        Manager,
        Sales,
        Operater
    }
}
