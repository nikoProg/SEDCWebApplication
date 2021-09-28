using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SEDCWebApplication.BLL.Logic.Models;

namespace SEDCWebAPI.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        IEnumerable<EmployeeDTO> GetAllEmployees();
        EmployeeDTO GetEmployeeById(int id);
        EmployeeDTO Add(EmployeeDTO product);

        /*EmployeeDTO Update(EmployeeDTO employee);

        EmployeeDTO Delete(EmployeeDTO employee);*/
    }
}
