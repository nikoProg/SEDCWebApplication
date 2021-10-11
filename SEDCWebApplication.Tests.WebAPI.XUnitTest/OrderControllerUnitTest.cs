using Microsoft.AspNetCore.Mvc;
using SEDCWebAPI.Controllers;
using SEDCWebAPI.Services.Interfaces;
using SEDCWebApplication.BLL.Logic.Models;
using SEDCWebApplication.Tests.WebAPI.XUnitTest.Mock;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SEDCWebApplication.Tests.WebAPI.XUnitTest
{
    public class OrderControllerUnitTest
    {
        OrderController _controller;
        IDataService _service;
        //IEmployeeRepository _service;

        public OrderControllerUnitTest()
        {
            _service = new DataServiceMock();
            _controller = new OrderController(_service, null);
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
            var items = Assert.IsType<List<OrderDTO>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }

        [Theory]
        [InlineData(2)]
        public void GetById_WhenCalled_ReturnsOkResult(int id)
        {
            //Act
            var okResult = _controller.Get(id);

            //Assert
            Assert.IsType<OkObjectResult>(okResult.Result);
        }

        [Theory]
        [InlineData(2)]
        public void GetById_WhenCalled_ReturnsRightItem(int id)
        {
            //Act
            var okResult = _controller.Get(id).Result as OkObjectResult;

            //Assert
            var item = Assert.IsType<OrderDTO>(okResult.Value);
            Assert.Equal(840.00m, item.TotalAmount);
        }

    }
}
