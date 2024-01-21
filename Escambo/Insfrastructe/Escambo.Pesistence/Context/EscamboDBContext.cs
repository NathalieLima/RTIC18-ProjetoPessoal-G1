using Escambo.domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Escambo.Pesistence.Context;

public class EscamboDBContext: DbContext
{
    public EscamboDBContext(DbContextOptions<EscamboDBContext> options) : base(options) { }

    public DbSet<Service> Services { get; set; }
    public DbSet<Poster> Posters { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Chat> Chats { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<Avaluation> Avaluations { get; set; }


     #region Required
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(n => n.Name).IsRequired().HasMaxLength(100);
            entity.Property(e => e.Email).IsRequired().HasMaxLength(100);
            entity.Property(n => n.CPF).IsRequired();
            entity.Property(n => n.RG).IsRequired();
            entity.Property(n => n.Birth).IsRequired();
        });
    }
    #endregion
}