using System.ComponentModel.DataAnnotations;

namespace LPL_Systems.Models
{
    public class BaseModel
    {
        [Key]
        [Range(0, 12)]
        public int id { get; set; }
    }
}
