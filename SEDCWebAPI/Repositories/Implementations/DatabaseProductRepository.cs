using SEDCWebApplication.BLL.Logic.Interfaces;
using SEDCWebApplication.BLL.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDCWebAPI.Models.Repositories.Implementations
{
    public class DatabaseProductRepository : Interfaces.IProductRepository
    {
        private readonly IProductManager _productManager;
        public DatabaseProductRepository(IProductManager productManager)
        {
            _productManager = productManager;
        }

        public IEnumerable<ProductDTO> GetAllProducts()
        {
            return _productManager.GetAllProducts();
        }

        public ProductDTO GetProductById(int id)
        {
            return _productManager.GetProductById(id);
        }

        public ProductDTO Add(ProductDTO product)
        {
            return _productManager.Add(product);
        }
        public ProductDTO Update(ProductDTO product)
        {
            return _productManager.Update(product);
        }

        public void Delete(ProductDTO product)
        {
            //return _productManager.Delete(product);
        }
    }
}
