using System.ComponentModel.DataAnnotations;

namespace LPLSystems.Models
{
    public abstract class Person : BaseModel
    {
        [Required]
        [StringLength(30)]
        public string firstName { get; set; }

        [Required]
        [StringLength(30)]
        public string lastName { get; set; }

        [EmailAddress]
        public string emailAddress { get; set; }

        [Phone]
        public string phoneNumber { get; set; }

        public Person()
        {
            this.firstName = "";
            this.lastName = "";
            this.emailAddress = "";
            this.phoneNumber = "0000000000";
        }

        public Person(string firstName, string lastName, string emailAddress, string phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
            this.phoneNumber = phoneNumber;
        }
    }
}
