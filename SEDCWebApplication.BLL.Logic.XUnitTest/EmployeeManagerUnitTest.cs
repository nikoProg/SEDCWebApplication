using AutoMapper;
using Microsoft.Extensions.Configuration;
using SEDCWebApplication.BLL.Logic.Implementations;
using SEDCWebApplication.BLL.Logic.XUnitTest.Mock;
using SEDCWebApplication.DAL.DatabaseFactory.Interfaces;
using System;
using Xunit;

namespace SEDCWebApplication.BLL.Logic.XUnitTest
{
    public class EmployeeManagerUnitTest
    {
        EmployeeManager _manager;
        //IDataService _service;
        IEmployeeDAL _employeeDAL;
        IMapper _mapper;
        //ovo sam ostavio kao podsetnik jer ne znam za sta koristimo config i order
        IOrderDAL _orderDAL;
        IConfiguration configuration;

        public EmployeeManagerUnitTest()
        {
            _employeeDAL = new EmployeeRepositoryMock();
            _manager = new EmployeeManager(_employeeDAL, _mapper);
        }
        [Fact]
        public void Test1()
        {

        }
    }
}
