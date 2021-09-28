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
    public class CustomerManager : ICustomerManager
    {
        private readonly ICustomerDAL _customerDAL;
        private readonly IMapper _mapper;
        public CustomerManager(ICustomerDAL customerDAL, IMapper mapper)
        {
            _customerDAL = customerDAL;
            _mapper = mapper;
        }
        public CustomerDTO Add(CustomerDTO customer)
        {
            //Customer customerEntity = new Customer(null)
            //{
            //    Name = customer.Name,
            //    UserName = customer.Email
            //};
            Customer customerEntity = _mapper.Map<Customer>(customer);
            _customerDAL.Save(customerEntity);
            customer = _mapper.Map<CustomerDTO>(customerEntity);
            return customer;
        }
        public CustomerDTO Update(CustomerDTO customer)
        {
            Customer customerEntity = _mapper.Map<Customer>(customer);
            //customerEntity.EntityState = EntityStateEnum.Updated;
            _customerDAL.Save(customerEntity); // bilo je update, ali sam vratio na private...
            customer = _mapper.Map<CustomerDTO>(customerEntity);

            return customer;
        }

        public IEnumerable<CustomerDTO> GetAllCustomers()
        {
            return _mapper.Map<List<CustomerDTO>>(_customerDAL.GetAll(0, 50));
        }

        public CustomerDTO GetCustomerById(int id)
        {
            return _mapper.Map<CustomerDTO>(_customerDAL.GetById(id));
        }
    }
}
