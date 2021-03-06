using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyAddresses.Domain.Models
{
    public class Street : BaseModelWithName<Guid>
    {
        public Guid SettlementId { get; set; }
        public Settlement Settlement { get; set; }
        public List<Binding> Bindings { get; set; }
    }
}