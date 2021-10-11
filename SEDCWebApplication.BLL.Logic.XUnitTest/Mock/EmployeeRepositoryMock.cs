using SEDCWebApplication.DAL.DatabaseFactory.Entities;
using SEDCWebApplication.DAL.DatabaseFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDCWebApplication.BLL.Logic.XUnitTest.Mock
{
    class EmployeeRepositoryMock : IEmployeeDAL
    {
        public List<Employee> GetAll(int skip, int take)
        {
            throw new NotImplementedException();
        }

        public Employee GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Employee item)
        {
            throw new NotImplementedException();
        }
    }
}
