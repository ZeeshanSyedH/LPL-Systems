using System.ComponentModel.DataAnnotations;

namespace LPLSystems.Models
{
    public sealed class Employee : Person
    {

        [Required]
        public string password { get; set; }

        [Required]
        public string salt { get; set; }

        [Required]
        public string position { get; set; }

        public Employee()
        {
            // DEFAULT CONSTRUCTOR
        }

        public Employee(string firstName, string lastName, string emailAddress, string phoneNumber, string password, string position) : base(firstName, lastName, emailAddress, phoneNumber)
        {
            this.password = password;
            this.position = position;
        }

    }
}
