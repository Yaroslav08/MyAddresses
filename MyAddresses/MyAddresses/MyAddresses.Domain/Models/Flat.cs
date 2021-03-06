using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyAddresses.Domain.Models
{
    public class Flat : BaseModel<Guid>
    {
        public string Number { get; set; }
        public int Floor { get; set; }
        public int Entrance { get; set; } //номер під'їзду
        
        public Guid BindingId { get; set; }
        public Binding Binding { get; set; }
    }
}