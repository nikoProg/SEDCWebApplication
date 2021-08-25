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

namespace SEDCWebApplication.Controllers
{
    [Route("Employee")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        //private List<Employee> employees;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
            //MockEmployeeRepository mockEmployeeRepository = new MockEmployeeRepository();
            //employees = mockEmployeeRepository.GetAllEmployees().ToList();
            
        }


        [Route("List")]
        public IActionResult List()
        {

            List<Employee> employees = _employeeRepository.GetAllEmployees().ToList();
            ViewBag.Title = "Employees";

            return View(employees);
        }

        [Route("DetailsView/{id}")]
        public IActionResult Details(int id)
        {
            //MockEmployeeRepository mockEmployeeRepository = new MockEmployeeRepository();
            //Employee employee =  mockEmployeeRepository.GetEmployeeById(id);
            //Employee employee = employees.Where(x => x.Id == id).FirstOrDefault();
            
            Employee employee = _employeeRepository.GetEmployeeById(id);

            //EmployeeDetailsViewModel employeeVM = new EmployeeDetailsViewModel
            //{
            //    Employee = employee,
            //    PageTitle = "Employee's details"
            //};

            EmployeeDetailsViewModel employeeVM = new EmployeeDetailsViewModel();
            employeeVM.EmployeeName = employee.Name;
            employeeVM.Test = employee.Test;
            //employeeVM.EmployeeCompany = employee.Company;
            employeeVM.PageTitle = "Employee's details";

            return View(employeeVM);
        }

        [HttpGet]
        public IActionResult Create()
        {
            //EmployeeDetailsViewModel employeeVM = new EmployeeDetailsViewModel();
            /*employeeVM.Roles = new List<SelectListItem>
            {
                new SelectListItem {Text = "Shyju", Value = "1"},
                new SelectListItem {Text = "Sean", Value = "2"}
            };*/
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                Employee newEmployee = _employeeRepository.Add(employee);
                return RedirectToAction("Details", new { id = newEmployee.Id });
            } else
            {
                return View();
            }
            
        }
    }
}
