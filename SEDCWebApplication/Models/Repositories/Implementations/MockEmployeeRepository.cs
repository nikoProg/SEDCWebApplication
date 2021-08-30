using SEDCWebApplication.BLL.Logic.Models;

using SEDCWebApplication.Models.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDCWebApplication.Models.Repositories.Implementations
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<EmployeeDTO> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<EmployeeDTO>
            {
                new EmployeeDTO
                {
                    Id=1,
                    Name="Pera",
                    Role=BLL.Logic.Models.RoleEnum.Manager,
                    Test = true,
                    Email="test@sedcmail.com"
                },
                new EmployeeDTO
                {
                    Id=2,
                    Name="Mika",
                    Role=RoleEnum.Sales,
                    Test = false,
                    Email="test@sedcmail.com"
                },
                new EmployeeDTO
                {
                    Id=3,
                    Name="Laza",
                    Role=RoleEnum.Operater,
                    Email="test@sedcmail.com"
                }
            };
        }

        public IEnumerable<EmployeeDTO> GetAllEmployees()
        {
            return _employeeList;
        }

        public EmployeeDTO GetEmployeeById(int id)
        {
            return _employeeList.Where(x => x.Id == id).FirstOrDefault();
        }

        public EmployeeDTO Add(EmployeeDTO employee)
        {
            employee.Id = _employeeList.Max(e => e.Id) + 1;
            _employeeList.Add(employee);
            return _employeeList.Where(x => x.Id == employee.Id).FirstOrDefault();
        }

        public EmployeeDTO Update(EmployeeDTO employee)
        {
            throw new NotImplementedException();
        }
    }
}
