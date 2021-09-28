using SEDCWebApplication.BLL.Logic.Interfaces;
using SEDCWebApplication.BLL.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDCWebAPI.Repositories.Implementations
{
    public class DatabaseEmployeeRepository : Interfaces.IEmployeeRepository
    {
        private readonly IEmployeeManager _employeeManager;
        public DatabaseEmployeeRepository(IEmployeeManager employeeManager)
        {
            _employeeManager = employeeManager;
        }

        public IEnumerable<EmployeeDTO> GetAllEmployees()
        {
            return _employeeManager.GetAllEmployees();
        }

        public EmployeeDTO GetEmployeeById(int id)
        {
            return _employeeManager.GetEmployeeById(id);
        }

        public EmployeeDTO Add(EmployeeDTO employee)
        {
            return _employeeManager.Add(employee);
        }
        /*public EmployeeDTO Update(EmployeeDTO employee)
        {
            return _employeeManager.Update(employee);
        }

        public EmployeeDTO Delete(EmployeeDTO employee)
        {
            return _employeeManager.Delete(employee);
        }*/
    }
}
