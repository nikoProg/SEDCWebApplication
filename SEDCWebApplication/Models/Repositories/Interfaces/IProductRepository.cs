using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SEDCWebApplication.BLL.Logic.Models;

namespace SEDCWebApplication.Models.Repositories.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<ProductDTO> GetAllProducts();
        ProductDTO GetProductById(int id);
        ProductDTO Add(ProductDTO product);
        //DTO je pozeljan, ali vise ne moze da nam radi mock.
        ProductDTO Update(ProductDTO product);
    }
}
