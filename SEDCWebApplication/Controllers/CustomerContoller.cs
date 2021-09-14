using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SEDCWebApplication.BLL.Logic.Models;
using SEDCWebApplication.Models;
using SEDCWebApplication.Models.Repositories.Implementations;
using SEDCWebApplication.Models.Repositories.Interfaces;
using SEDCWebApplication.ViewModels;

namespace SEDCWebApplication.Controllers
{
    [Route("Customer")]
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public CustomerController(ICustomerRepository customerRepository, IWebHostEnvironment hostingEnvironment)
        {
            _customerRepository = customerRepository;
            _hostingEnvironment = hostingEnvironment;
        }

        //ne znam tacno kako bi radilo bez route, lakse mi je mnogo ovako, nego da trazim drugi nacin.
        [Route("List")]
        public IActionResult List()
        {
            //MockCustomerRepository mockCustomerRepository = new MockCustomerRepository();
            List<CustomerDTO> customers = _customerRepository.GetAllCustomers().ToList();

            //ViewBag.Customers = customers;
            //ViewData["Customers"] = customers;
            ViewBag.Title = "Customers";
            //ViewData["Title"] = "Customers";


            return View(customers);
        }

        [Route("Details/{id}")]
        public IActionResult Details(int id)
        {
            //MockCustomerRepository mockCustomerRepository = new MockCustomerRepository();
            CustomerDTO customer = _customerRepository.GetCustomerById(id);

            CustomerDetailsViewModel customerVM = new CustomerDetailsViewModel
            {
                Name = customer.Name,
                Email = customer.Email,
                ImagePath = customer.ImagePath,

                PageTitle = "Customer's details"
            };

            return View(customerVM);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CustomerCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = "avatar.png";
                if (model.Photo != null)
                {
                    string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "img");

                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    model.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                }

                CustomerDTO customer = new CustomerDTO
                {
                    Id = null,
                    Name = model.Name,
                    Email = model.Email,
                    ImagePath = "/img/" + uniqueFileName
                };
                CustomerDTO newCustomer = _customerRepository.Add(customer);
                return RedirectToAction("Details", new { id = newCustomer.Id });
            }
            else
            {
                return View();
            }

        }


        [HttpGet]
        [Route("Edit/{id}")]
        public IActionResult Edit(int id)
        {
            CustomerDTO customer = _customerRepository.GetCustomerById(id);

            //STVARNO ne znam da li je suvisno pretvarati DTO u CreateModel za Editovanje.
            CustomerCreateViewModel formCustomer = new CustomerCreateViewModel
            {
                Name = customer.Name,
                Email = customer.Email,
                ImagePath = customer.ImagePath,
                //Address = customer.Address
            };

            return View(formCustomer);
        }

        [HttpPost]
        [Route("Edit/{id}")]
        public IActionResult Edit(int id, CustomerCreateViewModel formCustomer)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = "avatar.png";
                if (formCustomer.Photo != null)
                {
                    string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "img");

                    uniqueFileName = Guid.NewGuid().ToString() + "_" + formCustomer.Photo.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    formCustomer.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                }

                CustomerDTO customer = _customerRepository.GetCustomerById(id);

                customer.Name = formCustomer.Name;
                customer.Email = formCustomer.Email;
                customer.ImagePath = "/img/" + uniqueFileName;

                customer = _customerRepository.Update(customer);//nisam znao gde da vratim objekat, mozda to kvari nesto???
                return RedirectToAction("Details", new { id });
            }
            else
            {
                return View();
            }

        }
    }
}
