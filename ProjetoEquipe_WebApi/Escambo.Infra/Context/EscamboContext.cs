
using Escambo.Domain.Entities;
using Escambo.Dommain.Model;
using Escambo.Infra.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Escambo.Infra.Context
{
    public class EscamboContext : DbContext
        {
        
        public DbSet<Login> Logins { get; set; }
        public DbSet<Anuncio> Anuncios { get; set; }
        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<Conversa> Contersas { get; set; }
        public DbSet<Mensagem> Mensagens { get; set; }
        public DbSet<PrestacaoServico> PrestacaoServicos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<ConversasHasUsuarios> ConversasHasUsuarios { get; set; }
        public DbSet<PrestacaoServicoHasAvaliacoes> PrestacaoServicoHasAvaliacoes { get; set; }
        public DbSet<PrestacaoServicoHasUsuarios> PrestacaoServicoHasUsuarios { get; set; }

        public EscamboContext(DbContextOptions<EscamboContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EscamboContext).Assembly);
        }
    }

}