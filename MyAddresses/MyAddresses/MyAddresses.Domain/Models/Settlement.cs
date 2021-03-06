using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyAddresses.Domain.Models
{
    public class Settlement : BaseModel<Guid>
    {
        [MinLength(5), MaxLength(200)]
        public string Population { get; set; }
        public SettlementType Type { get; set; }

        public Guid AreaId { get; set; }
        public Area Area { get; set; }
        public List<Street> Streets { get; set; }
    }

    public enum SettlementType
    {
        City,
        UrbanVillage,
        Village,
        Colony
    }
}