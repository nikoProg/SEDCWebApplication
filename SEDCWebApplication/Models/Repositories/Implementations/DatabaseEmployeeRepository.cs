using SEDCWebApplication.Models.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDCWebApplication.Models.Repositories.Implementations
{
    public class DatabaseEmployeeRepository : IEmployeeRepository
    {
        public IEnumerable<Employee> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployeeById(int id)
        {
            throw new NotImplementedException();
        }

        public Employee Add(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
