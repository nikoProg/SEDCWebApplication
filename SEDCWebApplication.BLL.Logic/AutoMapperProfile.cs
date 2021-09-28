using AutoMapper;
using SEDCWebApplication.BLL.Logic.Helpers;
using SEDCWebApplication.BLL.Logic.Models;
//using SEDCWebApplication.DAL.Data.Entities;
//ovde je doslo do kriticne greske sa rename-ovanjem namespace-a, pazi se visual studio recommenations
using SEDCWebApplication.DAL.DatabaseFactory.Entities;
using System;

namespace SEDCWebApplication.BLL.Logic
{
    public class AutoMapperProfile : Profile
    {

        public AutoMapperProfile()
        {
            CreateMap<Employee, EmployeeDTO>()
                .ForMember(dest => dest.Role, src => src.MapFrom(src => src.RoleId))
                    .ForMember(dest => dest.Email, src => src.MapFrom(src => src.UserName));

            CreateMap<EmployeeDTO, Employee>()
                .ForMember(dest => dest.UserName, src => src.MapFrom(src => src.Email))
                    .ForMember(dest => dest.RoleId, src => src.MapFrom(src => src.Role));

            CreateMap<Customer, CustomerDTO>()
                .ForMember(dest => dest.Email, src => src.MapFrom(src => src.UserName));

            CreateMap<CustomerDTO, Customer>()
                .ForMember(dest => dest.UserName, src => src.MapFrom(src => src.Email));

            CreateMap<Product, ProductDTO>();

            CreateMap<ProductDTO, Product>();


            CreateMap<DAL.DatabaseFactory.Entities.User, UserDTO>();
            //.ForMember(dest => dest.Role, src => src.MapFrom(src => EnumHelper.GetString()))
            //CreateMap<User, UserDTO>();

        }
    }
}
