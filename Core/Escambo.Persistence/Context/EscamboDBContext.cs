using Escambo.Domain.Entities;
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

}