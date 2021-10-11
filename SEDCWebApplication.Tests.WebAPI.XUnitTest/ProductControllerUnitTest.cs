using Microsoft.AspNetCore.Mvc;
using SEDCWebAPI.Controllers;
using SEDCWebAPI.Repositories.Interfaces;
using SEDCWebApplication.BLL.Logic.Models;
using SEDCWebApplication.Tests.WebAPI.XUnitTest.Mock;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SEDCWebApplication.Tests.WebAPI.XUnitTest
{
    public class ProductControllerUnitTest
    {
        ProductController _controller;
        //IDataService _service;
        IProductRepository _service;

        public ProductControllerUnitTest()
        {
            _service = new DataServiceMock();
            _controller = new ProductController(_service, null);
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
            var items = Assert.IsType<List<ProductDTO>>(okResult.Value);
            Assert.Equal(7, items.Count);
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
        [InlineData(2)]
        public void GetById_WhenCalled_ReturnsRightItem(int id)
        {
            //Act
            var okResult = _controller.Get(id).Result as OkObjectResult;

            //Assert
            var item = Assert.IsType<ProductDTO>(okResult.Value);
            Assert.Equal("Vegetariana", item.Name);
        }

        [Theory]
        [InlineData(3)]
        public void Delete_WhenCalled_ReturnsRightItem(int id)
        {
            //Act
            var okResult = _controller.Delete(id).Result as OkObjectResult;

            //Assert
            var item = Assert.IsType<ProductDTO>(okResult.Value);
            Assert.Equal("Capricciosa", item.Name);
            Assert.Equal(true, item.IsDeleted);
        }

        [Fact]
        public void Post_WhenCalled_ReturnsRightItem()
        {
            //Arrange
            ProductDTO testProduct = new ProductDTO
            {
                Name = "TestPizza",
                UnitPrice = 322.000F,
                IsActive = true,
                IsDeleted = false,
                IsDiscounted = false,
                Size = "medium",
                Description = "(test description)",
                ImagePath = "/img/delikatespizza.jpg"
            };

            //Act
            _controller.Post(testProduct);

            //Assert
            ProductDTO itemInList = _service.GetProductById(8);
            Assert.Equal("TestPizza", itemInList.Name);
        }
    }
}
