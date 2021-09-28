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
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public EmployeeController(IEmployeeRepository employeeRepository, IWebHostEnvironment hostingEnvironment)
        {
            _employeeRepository = employeeRepository;
            _hostingEnvironment = hostingEnvironment;
        }


        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<EmployeeDTO> Get()
        {
            return _employeeRepository.GetAllEmployees();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public EmployeeDTO Get(int id)
        {
            return _employeeRepository.GetEmployeeById(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public EmployeeDTO Post([FromBody] EmployeeDTO newEmployee)
        {
            EmployeeDTO employee = new EmployeeDTO
            {
                Name = newEmployee.Name,
                Gender = newEmployee.Gender,
                Role = newEmployee.Role,
                DateOfBirth = newEmployee.DateOfBirth,
                ImagePath = newEmployee.ImagePath
            };
            return _employeeRepository.Add(employee);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
