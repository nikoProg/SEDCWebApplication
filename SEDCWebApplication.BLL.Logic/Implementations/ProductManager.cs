using AutoMapper;
using SEDCWebApplication.BLL.Logic.Interfaces;
using SEDCWebApplication.BLL.Logic.Models;
//using SEDCWebApplication.DAL.Data.Entities;
//using SEDCWebApplication.DAL.Data.Interfaces;
using SEDCWebApplication.DAL.DatabaseFactory.Entities;
using SEDCWebApplication.DAL.DatabaseFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDCWebApplication.BLL.Logic.Implementations
{
    public class ProductManager : IProductManager
    {
        private readonly IProductDAL _productDAL;
        private readonly IMapper _mapper;
        public ProductManager(IProductDAL productDAL, IMapper mapper)
        {
            _productDAL = productDAL;
            _mapper = mapper;
        }
        public ProductDTO Add(ProductDTO product)
        {
            //Product productEntity = new Product(null)
            //{
            //    Name = product.Name,
            //    UserName = product.Email
            //};
            Product productEntity = _mapper.Map<Product>(product);
            _productDAL.Save(productEntity);
            product = _mapper.Map<ProductDTO>(productEntity);
            return product;
        }
        public ProductDTO Update(ProductDTO product)
        {
            Product productEntity = _mapper.Map<Product>(product);
            //productEntity.EntityState = EntityStateEnum.Updated;
            _productDAL.Save(productEntity); // bilo je update, ali sam vratio na private...
            product = _mapper.Map<ProductDTO>(productEntity);

            return product;
        }

        public IEnumerable<ProductDTO> GetAllProducts()
        {
            return _mapper.Map<List<ProductDTO>>(_productDAL.GetAll(0, 50));
        }

        public ProductDTO GetProductById(int id)
        {
            //_mapper.Map<ProductDTO>(_productDAL.GetById(id));
            try
            {
                Product product = _productDAL.GetById(id);
                if (product == null)
                {
                    throw new Exception($"Product with id {id} not found.");
                }
                ProductDTO productDTO = _mapper.Map<ProductDTO>(product);
                return productDTO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ProductDTO Delete(ProductDTO product)
        {

            Product productEntity = _mapper.Map<Product>(product);
            _productDAL.Delete(productEntity);
            product = _mapper.Map<ProductDTO>(productEntity);
            return product;
        }
    }
}
