using System;
using System.Collections.Generic;
using System.Text;

namespace MyAddresses.Application.ViewModels.User
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
    }
}