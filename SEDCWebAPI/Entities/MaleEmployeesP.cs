using System;
using System.Collections.Generic;

#nullable disable

namespace SEDCWebAPI.Entities
{
    public partial class MaleEmployeesP
    {
        public int? EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}
