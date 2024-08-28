﻿using AutoMapper;
using CSharp.Managers.ViewModels;

namespace CSharp.Managers.Mapping
{
    public class CustomerMappingProfile : Profile
    {
        public CustomerMappingProfile()
        {
            CreateMap<Customer, Accessors.DataTransferObjects.Customer>()
                .ReverseMap();
        }
    }
}
