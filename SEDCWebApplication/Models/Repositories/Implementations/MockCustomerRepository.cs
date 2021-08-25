using SEDCWebApplication.Models.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDCWebApplication.Models.Repositories.Implementations
{
    public class MockCustomerRepository : ICustomerRepository
    {
        private List<Customer> _customerList;
        public MockCustomerRepository()
        {
            _customerList = new List<Customer>
            {
                new Customer
                {
                    Id=1,
                    Name="Steva",
                    Phone="011555333"
                },
                new Customer
                {
                    Id=13,
                    Name="Adam",
                    Phone="018555333"
                },
                new Customer
                {
                    Id=42,
                    Name="Zorica",
                    Phone="061234567"
                }
            };
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _customerList;
        }

        public Customer GetCustomerById(int id)
        {
            return _customerList.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
