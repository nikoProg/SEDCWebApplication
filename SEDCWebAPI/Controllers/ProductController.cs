using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using SEDCWebAPI.Repositories.Interfaces;
using SEDCWebApplication.BLL.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SEDCWebAPI.Controllers
{
    //[EnableCors("CorsPolicy")]
    //[Authorize]
    //[AllowAnonymous]
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
        public ActionResult<IEnumerable<ProductDTO>> Get()
        {
            return Ok(_productRepository.GetAllProducts());
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public ActionResult<ProductDTO> Get(int id)
        {
            return Ok(_productRepository.GetProductById(id));
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
                IsActive = newProduct.IsActive,
                IsDeleted = newProduct.IsDeleted,
                ImagePath = newProduct.ImagePath
            };
            return _productRepository.Add(product);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public ProductDTO Put(int id, [FromBody] ProductDTO newProduct)
        {
            ProductDTO product = new ProductDTO
            {
                Name = newProduct.Name,
                Size = newProduct.Size,
                UnitPrice = newProduct.UnitPrice,
                Description = newProduct.Description,
                IsDiscounted = newProduct.IsDiscounted,
                IsActive = newProduct.IsActive,
                IsDeleted = newProduct.IsDeleted,
                ImagePath = newProduct.ImagePath
            };
            return _productRepository.Update(id, product);//update ili edit?
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public ActionResult<ProductDTO> Delete(int id)
        {
            return Ok(_productRepository.Delete(_productRepository.GetProductById(id)));
            
        }
    }
}
