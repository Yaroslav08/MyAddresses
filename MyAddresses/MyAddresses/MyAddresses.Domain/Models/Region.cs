﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyAddresses.Domain.Models
{
    public class Region : BaseModel<Guid>
    {
        [Required, MaxLength(100)]
        public string Name { get; set; }
    }
}