using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDCWebApplication.Models;
using SEDCWebApplication.Models.Repositories.Implementations;
using SEDCWebApplication.Models.Repositories.Interfaces;
using SEDCWebApplication.ViewModels;

namespace SEDCWebApplication.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerRepository _customerRepository;
        public IActionResult List()
        {
            MockCustomerRepository mockCustomerRepository = new MockCustomerRepository();
            List<Customer> customers = mockCustomerRepository.GetAllCustomers().ToList();

            ViewBag.Customers = customers;
            //ViewData["Customers"] = customers;
            ViewBag.Title = "customers runtime";
            //ViewData["Title"] = "Customers";


            return View(customers);
        }

        [Route("Customer/Details/{id}")]
        public IActionResult Details(int id)
        {
            MockCustomerRepository mockCustomerRepository = new MockCustomerRepository();
            Customer customer = mockCustomerRepository.GetCustomerById(id);

            CustomerDetailsViewModel customerVM = new CustomerDetailsViewModel
            {
                Customer = customer,
                PageTitle = "Customer's details"
            };

            return View(customerVM);
        }
    }
}
