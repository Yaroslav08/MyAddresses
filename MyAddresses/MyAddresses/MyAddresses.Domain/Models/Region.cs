using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyAddresses.Domain.Models
{
    public class Region : BaseModel<Guid>
    {
        [MinLength(5), MaxLength(200)]
        public string Population { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}