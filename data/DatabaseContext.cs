using Microsoft.EntityFrameworkCore;
using Registration.Models;

namespace Registration.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) {
        }

        public DbSet<RegistrationModel> Registrations { get; set; }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<RegistrationModel>()
        //         .HasAlternateKey(c => c.Email)
        //         .HasName("AlternateKey_EmailID");
        // }

    }
}
