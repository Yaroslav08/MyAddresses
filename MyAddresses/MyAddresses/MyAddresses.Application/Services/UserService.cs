using AutoMapper;
using MyAddresses.Application.Interfaces;
using MyAddresses.Application.ViewModels.User;
using MyAddresses.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyAddresses.Application.Services
{
    public class UserService : IUserService
    {
        private IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public UserService(IUnitOfWork _unitOfWork, IMapper _mapper)
        {
            unitOfWork = _unitOfWork;
            mapper = _mapper;
        }

        public async Task<UserViewModel> GetUserById(int id)
        {
            return mapper.Map<UserViewModel>(await unitOfWork.UserRepository.GetByWhereAsync(d => d.Id == id));
        }
    }
}