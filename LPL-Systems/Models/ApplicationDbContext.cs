using System.Data.Entity;

namespace LPL_Systems.Models
{
    class ApplicationDbContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Employee> Employees { get; set; }


        public ApplicationDbContext()
            : base("DefaultConnection")
        { }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
