using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDCWebApplication.Models.Repositories.Interfaces
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);

        Customer Add(Customer customer);
    }
}
