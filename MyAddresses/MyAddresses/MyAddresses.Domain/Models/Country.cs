using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyAddresses.Domain.Models
{
    public class Country : BaseModelWithName<int>
    {
        [MinLength(5), MaxLength(200)]
        public string Population { get; set; }
        [StringLength(5000)]
        public string History { get; set; }
        public List<Region> Regions { get; set; }
    }
}