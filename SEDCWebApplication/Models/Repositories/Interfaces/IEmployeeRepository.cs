using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SEDCWebApplication.BLL.Logic.Models;

namespace SEDCWebApplication.Models.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        IEnumerable<EmployeeDTO> GetAllEmployees();
        EmployeeDTO GetEmployeeById(int id);
        EmployeeDTO Add(EmployeeDTO employee);
        //DTO je pozeljan, ali vise ne moze da nam radi mock.
        EmployeeDTO Update(EmployeeDTO employee);
    }
}
