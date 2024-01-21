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
    public DbSet<Advertisement> Advertisement { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        var connectionString = "server=localhost;user=dotnet;password=tic2023;database=escambo";
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }

    #region Configuracao do modelo de dados
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>().ToTable("users").HasKey(u => u.UserId);
        modelBuilder.Entity<User>().Property(u => u.Name).IsRequired();
        
        modelBuilder.Entity<Advertisement>().ToTable("advertisements").HasKey(a => a.AdvertisementId);
        modelBuilder.Entity<Advertisement>().Property(a => a.Name).IsRequired();
        
        //Um Usuario pode ter muitos Anuncios de Servicos.
        modelBuilder.Entity<Advertisement>()
            .HasOne(a => a.User)//Cada Anuncio está associado a apenas um Usuario
            .WithMany(u => u.Advertisements)//Um Usuario pode ter muitos anuncios
            .HasForeignKey(a => a.UserId);
             //Um Usuario pode ter muitas Avaliacoes
        //e uma Avaliacao pode estar associada a muitos Usuarios
        // (um usuário como avaliador e outro como avaliado).
        modelBuilder.Entity<Avaluation>()
        .HasOne(a => a.Avaliador)
        .WithMany(u => u.EvaluationsAsEvaluator)
        .HasForeignKey(a => a.AvaliadorId);

        modelBuilder.Entity<Avaluation>()
        .HasOne(a => a.Avaliado)
        .WithMany(u => u.EvaluationsAsEvaluated);
    }


    #endregion
}
