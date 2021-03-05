using AutoMapper;
using MyAddresses.Application.ViewModels.User;
using MyAddresses.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAddresses.Application
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<User, UserViewModel>();
        }
    }
}