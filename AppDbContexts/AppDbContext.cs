using Microsoft.EntityFrameworkCore;
using MotorcycleRacing.Entities;

namespace MotorcycleRacing.AppDbContexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<MotoGP> motos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = MIELODIE\\SQLEXPRESS; database = MotorcycleRacing; integrated security = sspi; encrypt = true; trustservercertificate = true;");
        }
    }
}
