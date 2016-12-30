using System.ComponentModel.DataAnnotations;

namespace LPL_Systems.Models
{
    public class Client
    {
        [Key]
        public int organizationID { get; set; }

        [Required]
        public string organizationName { get; set; }

        [Required]
        public Address Address { get; set; }

        public int addressID { get; set; }

        [Url]
        public string organizationURL { get; set; }

        [Required]
        public Employee Employee { get; set; }

        [Range(0, 12)]
        public int employeeID { get; set; }
    }
}
