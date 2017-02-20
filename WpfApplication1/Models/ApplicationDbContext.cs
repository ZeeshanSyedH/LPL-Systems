using System.Data.Entity;

namespace LPLSystems.Models
{
    class ApplicationDbContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Invoice> Invoices { get; set; }

        public ApplicationDbContext()
                : base("DefaultConnection")
        { }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>().Property(x => x.id).HasColumnName("employeeId");
            modelBuilder.Entity<Client>().Property(x => x.id).HasColumnName("organizationID");
        }
    }
}
