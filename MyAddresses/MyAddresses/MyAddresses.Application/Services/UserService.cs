using AutoMapper;
using MyAddresses.Application.Interfaces;
using MyAddresses.Application.ViewModels.User;
using MyAddresses.Domain.Interfaces;
using MyAddresses.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyAddresses.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper mapper;
        public UserService(IMapper _mapper, IUserRepository userRepository)
        {
            mapper = _mapper;
            _userRepository = userRepository;
        }

        public async Task<UserViewModel> GetUserById(int id)
        {
            return mapper.Map<UserViewModel>(await _userRepository.GetByWhereAsync(d => d.Id == id));
        }
    }
}