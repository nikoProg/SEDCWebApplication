﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SEDCWebAPI.Entities
{
    public partial class VvCustomerTotalAmount
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public decimal? TotalAmount { get; set; }
    }
}
