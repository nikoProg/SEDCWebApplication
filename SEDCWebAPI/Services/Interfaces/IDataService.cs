using SEDCWebApplication.BLL.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDCWebAPI.Services.Interfaces
{
    public interface IDataService
    {
        OrderDTO AddOrder(OrderDTO order);

        IEnumerable<EmployeeDTO> GetAllEmployees();
        EmployeeDTO GetEmployeeById(int id);
        EmployeeDTO AddEmployee(EmployeeDTO employee);
    }
}
