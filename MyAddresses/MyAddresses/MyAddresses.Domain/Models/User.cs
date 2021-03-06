using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyAddresses.Domain.Models
{
    public class User : BaseModel<int>
    {
        [Required, MinLength(2), MaxLength(250)]
        public string FullName { get; set; }
        [MinLength(5), MaxLength(200)]
        public string Login { get; set; }
        [MinLength(10), MaxLength(5000)]
        public string PasswordHash { get; set; }
    }
}