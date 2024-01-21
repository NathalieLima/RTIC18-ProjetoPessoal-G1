using Escambo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Escambo.Pesistence.Context;

public class EscamboContext: DbContext
{
    

    public DbSet<Service> Services { get; set; }
    public DbSet<Poster> Posters { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Chat> Chats { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<Avaluation> Avaluations { get; set; }


     #region Required

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        var connectionString = "server=localhost;user=User;password=d@n!&L702203";
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>().ToTable("Users");
    }


    #endregion
}