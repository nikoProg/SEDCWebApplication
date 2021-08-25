﻿using SEDCWebApplication.Models.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDCWebApplication.Models.Repositories.Implementations
{
    public class MockProductRepository : IProductRepository
    {
        private List<Product> _productList;
        public MockProductRepository()
        {
            _productList = new List<Product>
            {
                new Product
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
                new Product
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
                new Product
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
                new Product
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
                new Product
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
                new Product
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
                new Product
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
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productList;
        }

        public Product GetProductById(int id)
        {
            return _productList.Where(x => x.Id == id).FirstOrDefault();
        }

        public Product Add(Product product)
        {
            product.Id = _productList.Max(e => e.Id) + 1;
            _productList.Add(product);
            return _productList.Where(x => x.Id == product.Id).FirstOrDefault();
        }
    }
}
