using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using SEDCWebAPI.Models.Repositories.Interfaces;
using SEDCWebApplication.BLL.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SEDCWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public ProductController(IProductRepository productRepository, IWebHostEnvironment hostingEnvironment)
        {
            _productRepository = productRepository;
            _hostingEnvironment = hostingEnvironment;
        }

        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<ProductDTO> Get()
        {
            return _productRepository.GetAllProducts();
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public ProductDTO Get(int id)
        {
            return _productRepository.GetProductById(id);
        }

        // POST api/<ProductController>
        [HttpPost]
        public ProductDTO Post([FromBody] ProductDTO newProduct)
        {
            ProductDTO product = new ProductDTO
            {
                Name = newProduct.Name,
                Size = newProduct.Size,
                UnitPrice = newProduct.UnitPrice,
                Description = newProduct.Description,
                IsDiscounted = newProduct.IsDiscounted,
                ImagePath = newProduct.ImagePath
            };
            return _productRepository.Add(product);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           // _productRepository.Delete(_productRepository.GetById(id));
            
        }
    }
}
