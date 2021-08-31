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
    [Route("Employee")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IWebHostEnvironment _hostingEnvironment;

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

            List<EmployeeDTO> employees = _employeeRepository.GetAllEmployees().ToList();
            ViewBag.Title = "Employees";

            return View(employees);
        }

        [Route("DetailsView/{id}")]
        public IActionResult Details(int id)
        {
            //MockEmployeeRepository mockEmployeeRepository = new MockEmployeeRepository();
            //Employee employee =  mockEmployeeRepository.GetEmployeeById(id);
            //Employee employee = employees.Where(x => x.Id == id).FirstOrDefault();

            EmployeeDTO employee = _employeeRepository.GetEmployeeById(id);

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
            //employeeVM.Email = employee.Email;
            employeeVM.Role = employee.Role.ToString();

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
        public IActionResult Create(EmployeeCreateViewModel model)
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

                EmployeeDTO employee = new EmployeeDTO
                {
                    Id = null,
                    Name = model.Name,
                    Email = model.Email,
                    Role = model.Role,
                    Gender = model.Gender,
                    DateOfBirth = model.DateOfBirth,
                    ImagePath = "~/img/" + uniqueFileName
                };
            
                EmployeeDTO newEmployee = _employeeRepository.Add(employee);
                return RedirectToAction("Details", new { id = newEmployee.Id });
            } else
            {
                return View();
            }
            
        }

        [HttpGet]
        [Route("Edit/{id}")]
        public IActionResult Edit(int id)
        {
            EmployeeDTO employee = _employeeRepository.GetEmployeeById(id);

            return View(employee);
        }


        [HttpPost]
        [Route("Edit/{id}")]
        public IActionResult Edit(int id, EmployeeDTO formEmployee)
        {
            //MockEmployeeRepository mockEmployeeRepository = new MockEmployeeRepository();
            //EmployeeDTO employee = mockEmployeeRepository.GetEmployeeById(changedEmployee.Id);

            if (ModelState.IsValid)
            {
                EmployeeDTO employee = _employeeRepository.GetEmployeeById((int)formEmployee.Id);

                //moze mapper?
                employee.Name = formEmployee.Name;
                employee.Role = formEmployee.Role;
                employee.Gender = formEmployee.Gender;
                employee.DateOfBirth = formEmployee.DateOfBirth;
                employee.Email = formEmployee.Email;

                employee = _employeeRepository.Update(employee);
                return RedirectToAction("Details", new { id = formEmployee.Id });
            }
            else
            {
                return View();
            }
        }
    }
}
