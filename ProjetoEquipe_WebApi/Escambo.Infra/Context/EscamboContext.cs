
using Escambo.Domain.Entities;
using Escambo.Infra.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Escambo.Infra.Context
{
    public class EscamboContext : DbContext
    {

        public EscamboContext(DbContextOptions<EscamboContext> options) : base(options)
    {
    }       
     public DbSet<Login> Logins { get; set; }

       

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     var connectionString = "server=localhost;user=User;password=d@n!&L702203;database=escambo;";
        //     var serverVersion = ServerVersion.AutoDetect(connectionString);
        //     optionsBuilder.UseMySql(connectionString, serverVersion);
        // }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EscamboContext).Assembly);
        }
    }
}