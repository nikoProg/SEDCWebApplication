using SEDCWebAPI.Services.Interfaces;
using SEDCWebApplication.BLL.Logic.Interfaces;
using SEDCWebApplication.BLL.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDCWebAPI.Services.Implementations
{
    public class DataService : IDataService
    {
        private readonly IOrderManager _orderManager;
        private readonly IEmployeeManager _employeeManager;
        public DataService(IOrderManager orderManager, IEmployeeManager employeeManager)
        {
            _orderManager = orderManager;
            _employeeManager = employeeManager;
        }
        public OrderDTO AddOrder(OrderDTO order)
        {
            return _orderManager.Add(order);
        }

        public IEnumerable<EmployeeDTO> GetAllEmployees()
        {
            return _employeeManager.GetAllEmployees();
        }

        public EmployeeDTO GetEmployeeById(int id)
        {
            try
            {
                return _employeeManager.GetEmployeeById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public EmployeeDTO AddEmployee(EmployeeDTO employee)
        {
            return _employeeManager.Add(employee);
        }
    }
}
