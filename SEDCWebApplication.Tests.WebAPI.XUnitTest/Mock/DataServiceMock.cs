using SEDCWebAPI.Repositories.Interfaces;
using SEDCWebAPI.Services.Interfaces;
using SEDCWebApplication.BLL.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDCWebApplication.Tests.WebAPI.XUnitTest.Mock
{
    public class DataServiceMock : IEmployeeRepository, IProductRepository, IDataService
    {
        private List<EmployeeDTO> _employeeList;
        private List<ProductDTO> _productList;
        private List<OrderDTO> _orderList;

        public DataServiceMock()
        {
            _employeeList = new List<EmployeeDTO>
            {
                new EmployeeDTO
                {
                    Id=1,
                    Name="Pera",
                    Role=BLL.Logic.Models.RoleEnum.Manager,
                    //Test = true,
                    Email="test@sedcmail.com"
                },
                new EmployeeDTO
                {
                    Id=2,
                    Name="Mika",
                    Role=RoleEnum.Sales,
                    //Test = false,
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
            _productList = new List<ProductDTO>
            {
                new ProductDTO
                {
                    Id=1,
                    Name="Margherita",
                    UnitPrice=180.000F,
                    IsActive = true,
                    IsDeleted = false,
                    IsDiscounted = false,
                    Size = "small",
                    Description = "(sir, kečap, šampinjoni, masline)",
                    ImagePath = "/img/1200px-Eataly_Las_Vegas_-_Feb_2019_-_Stierch_12.jpg"
                },
                new ProductDTO
                {
                    Id=2,
                    Name="Vegetariana",
                    UnitPrice=190.000F,
                    IsActive = true,
                    IsDeleted = false,
                    IsDiscounted = false,
                    Size = "small",
                    Description = "(sir, kečap, paradajz, kukuruz, luk, paprika, masline)",
                    ImagePath = "/img/Pizza-Vegetariana-3-1024x683.jpg"

                },
                new ProductDTO
                {
                    Id=3,
                    Name="Capricciosa",
                    UnitPrice=220.000F,
                    IsActive = true,
                    IsDeleted = false,
                    IsDiscounted = false,
                    Size = "small",
                    Description = "(sir, kečap, šunka, šampinjoni)",
                    ImagePath = "/img/1280px-Pizza_capricciosa.jpg"
                },
                new ProductDTO
                {
                    Id=4,
                    Name="Specijal",
                    UnitPrice=260.000F,
                    IsActive = true,
                    IsDeleted = false,
                    IsDiscounted = false,
                    Size = "small",
                    Description = "(sir, kečap, šunka, šampinjoni)",
                    ImagePath = "/img/1280px-Pizza_capricciosa.jpg"
                },
                new ProductDTO
                {
                    Id=5,
                    Name="Rukola",
                    UnitPrice=260.000F,
                    IsActive = true,
                    IsDeleted = false,
                    IsDiscounted = false,
                    Size = "small",
                    Description = "(sir, kečap, šunka, šampinjoni)",
                    ImagePath = "/img/2841-Rucola-Tomaat-Pizza_2566.jpg"
                },
                new ProductDTO
                {
                    Id=6,
                    Name="Srpska",
                    UnitPrice=280.000F,
                    IsActive = true,
                    IsDeleted = false,
                    IsDiscounted = false,
                    Size = "small",
                    Description = "(sir, kečap, šunka, šampinjoni)",
                    ImagePath = "/img/srpska-pica.jpg"
                },
                new ProductDTO
                {
                    Id=7,
                    Name="Delikates",
                    UnitPrice=280.000F,
                    IsActive = true,
                    IsDeleted = false,
                    IsDiscounted = false,
                    Size = "small",
                    Description = "(sir, kečap, šunka, šampinjoni)",
                    ImagePath = "/img/delikatespizza.jpg"
                }

            };
            _orderList = new List<OrderDTO>
            {
                new OrderDTO
                {
                    Id=1,
                    Number="N1",
                    Date=DateTime.MinValue,
                    TotalAmount=500.00m,
                    Status=1
                },
                new OrderDTO
                {
                    Id=2,
                    Number="N2",
                    Date=DateTime.Parse("2021-09-28 20:24:45.3159744"),
                    TotalAmount=(decimal)840.00,
                    Status=1
                },
                new OrderDTO
                {
                    Id=3,
                    Number="N3",
                    Date=DateTime.Parse("2021-09-28 21:29:43.1976515"),
                    TotalAmount=1100,
                    Status=1
                }
            };
        }

        public EmployeeDTO Add(EmployeeDTO employee)//zove se EmployeeAdd kod milosa
        {
            employee.Id = _employeeList.Max(e => e.Id) + 1;
            _employeeList.Add(employee);
            return _employeeList.Where(x => x.Id == employee.Id).FirstOrDefault();
        }

        public IEnumerable<EmployeeDTO> GetAllEmployees()
        {
            return _employeeList;
        }

        public EmployeeDTO GetEmployeeById(int id)
        {
            return _employeeList.Where(x => x.Id == id).FirstOrDefault();
        }

        public ProductDTO Add(ProductDTO product)//zove se ProductAdd kod milosa
        {
            product.Id = _productList.Max(e => e.Id) + 1;
            _productList.Add(product);
            return _productList.Where(x => x.Id == product.Id).FirstOrDefault();
        }

        public IEnumerable<ProductDTO> GetAllProducts()
        {
            return _productList;
        }

        public ProductDTO GetProductById(int id)
        {
            return _productList.Where(x => x.Id == id).FirstOrDefault();
        }

        public ProductDTO Delete(ProductDTO product)
        {
            product.IsDeleted = true;
            return product;
        }

        public OrderDTO AddOrder(OrderDTO order)
        {
            throw new NotImplementedException();
        }

        public EmployeeDTO AddEmployee(EmployeeDTO employee)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDTO> GetAllOrders()
        {
            return _orderList;
        }

        public OrderDTO GetOrderById(int id)
        {
            return _orderList.Where(x => x.Id == id).FirstOrDefault();
        }



        public ProductDTO Update(ProductDTO product)
        {
            throw new NotImplementedException();
        }
    }
}
