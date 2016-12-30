using System.ComponentModel.DataAnnotations;

namespace LPL_Systems.Models
{
    public sealed class Employee : Person
    {
        [Key]
        [Range(0, 12)]

        public int employeeId { get; set; }

        [Required]
        public string password { get; set; }

        [Required]
        public string position { get; set; }

        public Employee()
        {
            // DEFAULT CONSTRUCTOR
        }

        public Employee(string firstName, string lastName, string emailAddress, double phoneNumber, string password, string position) : base(firstName, lastName, emailAddress, phoneNumber)
        {
            this.password = password;
            this.position = position;
        }

    }
}
