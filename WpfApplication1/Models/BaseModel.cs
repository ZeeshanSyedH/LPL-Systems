using System;
using System.ComponentModel.DataAnnotations;

namespace LPLSystems.Models
{
    public class BaseModel
    {
        [Key]
        [Range(0, 12)]
        public Guid id { get; set; }
    }
}
