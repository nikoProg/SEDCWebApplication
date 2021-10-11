using System;
using System.Collections.Generic;
using System.Text;

namespace SEDCWebApplication.BLL.Logic.Models
{
    public class OrderDTO
    {
        public int? Id { get; set; }//Id je dodat tek za test, jer metoda getbyid ne moze da radi, moze getbyordernumber?

        public string Number { get; set; }

        public DateTime Date { get; set; }

        public decimal TotalAmount { get; set; }

        public int Status { get; set; }

        //public Employee Employee { get; set; }

        public List<OrderItemDTO> OrderItems { get; set; }
    }
}
