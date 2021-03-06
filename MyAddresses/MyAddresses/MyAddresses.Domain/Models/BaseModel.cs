using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAddresses.Domain.Models
{
    public class BaseModel
    {
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [MinLength(1), MaxLength(50)]
        public string CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        [MinLength(1), MaxLength(50)]
        public string UpdatedBy { get; set; }
    }


    public class BaseModel<TypeId> : BaseModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public TypeId Id { get; set; }
    }

    public class BaseModelWithName<TypeId> : BaseModel<TypeId>
    {
        [Required, MinLength(1), MaxLength(150)]
        public string Name { get; set; }
    }
}
