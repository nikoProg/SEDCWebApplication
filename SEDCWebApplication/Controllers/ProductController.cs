using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SEDCWebApplication.Models;
using SEDCWebApplication.Models.Repositories.Implementations;
using SEDCWebApplication.Models.Repositories.Interfaces;
using SEDCWebApplication.ViewModels;

using SEDCWebApplication.BLL.Logic.Models;
using Microsoft.AspNetCore.Hosting;

namespace SEDCWebApplication.Controllers
{
    [Route("Product")]
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public ProductController(IProductRepository productRepository, IWebHostEnvironment hostingEnvironment)
        {
            _productRepository = productRepository;
            _hostingEnvironment = hostingEnvironment;
        }



        [Route("List")]
        public IActionResult List()
        {

            List<ProductDTO> products = _productRepository.GetAllProducts().ToList();
            ViewBag.Title = "Products";

            return View(products);
        }

        [Route("Details/{id}")]
        public IActionResult Details(int id)
        {
            ProductDTO product = _productRepository.GetProductById(id);

            ProductDetailsViewModel productVM = new ProductDetailsViewModel
            {
                //nisu svi properti potrebni
                Name = product.Name,
                UnitPrice = product.UnitPrice,
                IsDiscounted = product.IsDiscounted,
                IsActive = product.IsActive,
                IsDeleted = product.IsDeleted,
                Size = product.Size,
                Description = product.Description,
                ImagePath = product.ImagePath
            };

            return View(productVM);
        }

        [HttpGet]
        public IActionResult Create()
        {
            /*ProductDetailsViewModel productVM = new ProductDetailsViewModel();
            productVM.SizeList = new List<SelectListItem>
            {
                new SelectListItem {Text = "small", Value = "1"},
                new SelectListItem {Text = "medium", Value = "2"},
                new SelectListItem {Text = "large", Value = "3"}
            };*/
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductDTO product)
        {
            if (ModelState.IsValid)
            {
                ProductDTO newProduct = _productRepository.Add(product);
                newProduct.ImagePath = "/img/defaultpizza.jpg";
                return RedirectToAction("Details", new { id = newProduct.Id });
            }
            else
            {
                return View();
            }

        }
    }
}
