using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SEDCWebApplication.BLL.Logic.Models;

namespace SEDCWebApplication.Models.Repositories.Interfaces
{
    public interface ICustomerRepository
    {
        IEnumerable<CustomerDTO> GetAllCustomers();

        CustomerDTO GetCustomerById(int id);

        CustomerDTO Add(CustomerDTO customer);

        CustomerDTO Update(CustomerDTO customer);
    }
}
