﻿using AutoMapper;
using SEDCWebApplication.BLL.Logic.Interfaces;
using SEDCWebApplication.BLL.Logic.Models;
using SEDCWebApplication.DAL.Data.Entities;
using SEDCWebApplication.DAL.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDCWebApplication.BLL.Logic.Implementations
{
    public class EmployeeManager : IEmployeeManager
    {
        private readonly IEmployeeDAL _employeeDAL;
        private readonly IMapper _mapper;
        public EmployeeManager(IEmployeeDAL employeeDAL, IMapper mapper)
        {
            _employeeDAL = employeeDAL;
            _mapper = mapper;
        }
        public EmployeeDTO Add(EmployeeDTO employee)
        {
            //Employee employeeEntity = new Employee(null)
            //{
            //    Name = employee.Name,
            //    UserName = employee.Email
            //};
            Employee employeeEntity = _mapper.Map<Employee>(employee);
            _employeeDAL.Save(employeeEntity);
            employee = _mapper.Map<EmployeeDTO>(employeeEntity);
            return employee;
        }
        public EmployeeDTO Update(EmployeeDTO employee)
        {
            Employee employeeEntity = _mapper.Map<Employee>(employee);
            employeeEntity.EntityState = EntityStateEnum.Updated;
            _employeeDAL.Save(employeeEntity); // bilo je update, ali sam vratio na private...
            employee = _mapper.Map<EmployeeDTO>(employeeEntity);

            return employee;
        }

        public IEnumerable<EmployeeDTO> GetAllEmployees()
        {
            return _mapper.Map<List<EmployeeDTO>>(_employeeDAL.GetAll(0, 50));
        }

        public EmployeeDTO GetEmployeeById(int id)
        {
            return _mapper.Map<EmployeeDTO>(_employeeDAL.GetById(id));
        }
    }
}
