using MyAddresses.Application.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyAddresses.Application.Interfaces
{
    public interface IUserService
    {
        Task<UserViewModel> GetUserById(int id);
    }
}