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

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        var connectionString = "server=localhost;user=root;database=escambo;port=3306;password=123456";
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>().ToTable("Users");
    }


    #endregion
}