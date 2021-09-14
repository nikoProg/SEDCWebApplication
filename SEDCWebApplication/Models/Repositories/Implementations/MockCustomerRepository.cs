using SEDCWebApplication.Models.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SEDCWebApplication.BLL.Logic.Models;

namespace SEDCWebApplication.Models.Repositories.Implementations
{
    public class MockCustomerRepository : ICustomerRepository
    {
        private List<CustomerDTO> _customerList;
        public MockCustomerRepository()
        {
            _customerList = new List<CustomerDTO>
            {
                new CustomerDTO
                {
                    Id=1,
                    Name="Steva",
                    //Phone="011555333"
                },
                new CustomerDTO
                {
                    Id=13,
                    Name="Adam",
                    //Phone="018555333"
                },
                new CustomerDTO
                {
                    Id=42,
                    Name="Zorica",
                    //Phone="061234567"
                }
            };
        }

        public IEnumerable<CustomerDTO> GetAllCustomers()
        {
            return _customerList;
        }

        public CustomerDTO GetCustomerById(int id)
        {
            return _customerList.Where(x => x.Id == id).FirstOrDefault();
        }

        public CustomerDTO Add(CustomerDTO customer)
        {
            customer.Id = _customerList.Max(e => e.Id) + 1;
            _customerList.Add(customer);
            return _customerList.Where(x => x.Id == customer.Id).FirstOrDefault();
        }

        public CustomerDTO Update(CustomerDTO customer)
        {
            throw new NotImplementedException();
        }
    }
}
