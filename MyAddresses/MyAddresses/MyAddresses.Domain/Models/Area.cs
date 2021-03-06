using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyAddresses.Domain.Models
{
    public class Area : BaseModelWithName<Guid>
    {
        public Guid RegionId { get; set; }
        public Region Region { get; set; }
        public List<Settlement> Settlements { get; set; }
    }
}