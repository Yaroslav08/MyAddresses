using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyAddresses.Domain.Models
{
    public class Binding : BaseModel<Guid>
    {
        [Required]
        public bool IsPrivate { get; set; } = false;
        [MinLength(1), MaxLength(200)]
        public string HouseName { get; set; }
        [MinLength(1), MaxLength(200), Url]
        public string Site { get; set; } 

        public Guid StreetId { get; set; }
        public Street Street { get; set; }

        public List<Flat> Flats { get; set; }
    }
}