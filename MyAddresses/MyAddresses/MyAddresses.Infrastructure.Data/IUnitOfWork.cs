using MyAddresses.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAddresses.Infrastructure.Data
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
    }
}