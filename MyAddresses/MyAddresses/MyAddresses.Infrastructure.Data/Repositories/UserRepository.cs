using MyAddresses.Domain.Interfaces;
using MyAddresses.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAddresses.Infrastructure.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {

    }
}