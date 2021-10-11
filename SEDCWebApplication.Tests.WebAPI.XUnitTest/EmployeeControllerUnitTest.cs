using Microsoft.AspNetCore.Mvc;
using SEDCWebAPI.Controllers;
using SEDCWebAPI.Repositories.Interfaces;
using SEDCWebApplication.BLL.Logic.Models;
using SEDCWebApplication.Tests.WebAPI.XUnitTest.Mock;
using System;
using System.Collections.Generic;
using Xunit;

namespace SEDCWebApplication.Tests.WebAPI.XUnitTest
{
    public class EmployeeControllerUnitTest
    {
        EmployeeController _controller;
        //IDataService _service;
        IEmployeeRepository _service;

        public EmployeeControllerUnitTest()
        {
            _service = new DataServiceMock();
            _controller = new EmployeeController(_service, null );
        }

        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            //Act
            var okResult = _controller.Get();

            //Assert
            Assert.IsType<OkObjectResult>(okResult.Result);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsAllItems()
        {
            //Act
            var okResult = _controller.Get().Result as OkObjectResult;

            //Assert
            var items = Assert.IsType<List<EmployeeDTO>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }

        [Theory]
        [InlineData(1)]
        public void GetById_WhenCalled_ReturnsOkResult(int id)
        {
            //Act
            var okResult = _controller.Get(id);

            //Assert
            Assert.IsType<OkObjectResult>(okResult.Result);
        }

        [Theory]
        [InlineData(1)]
        public void GetById_WhenCalled_ReturnsRightItem(int id)
        {
            //Act
            var okResult = _controller.Get(id).Result as OkObjectResult;

            //Assert
            var item = Assert.IsType<EmployeeDTO>(okResult.Value);
            Assert.Equal("Pera", item.Name);
        }

        [Fact]
        public void Post_WhenCalled_ReturnsRightItem()
        {
            //Arrange
            EmployeeDTO testEmployee = new EmployeeDTO
            {
                Name = "Test Employee",
                Role = RoleEnum.Operater,
                Email = "xunittest@sedcmail.com"
            };

            //Act
            _controller.Post(testEmployee);

            //Assert
            EmployeeDTO itemInList = _service.GetEmployeeById(4);
            Assert.Equal("Test Employee", itemInList.Name);
            Assert.Equal(RoleEnum.Operater, itemInList.Role);
        }
    }
}
