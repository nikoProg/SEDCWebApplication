using System;
using System.Collections.Generic;
using System.Text;

namespace SEDCWebApplication.DAL.DatabaseFactory.Entities
{
    public class Employee : User
    {
        /*public Employee(int? id)
        : base(id)
        {
        }*/
        public string Name { get; set; }

        public string Gender { get; set; }

        public int RoleId { get; set; }

        public DateTime? DateOfBirth { get; set; }
    }
}
