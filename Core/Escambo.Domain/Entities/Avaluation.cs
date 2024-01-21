using System.ComponentModel.DataAnnotations;

namespace Escambo.Domain.Entities
{
    public sealed class Avaluation : BaseEntity
    {
        public int AvaluationId { get; set; }

        // Referência para o anúncio
        public int PosterId { get; set; }
        public Poster Poster { get; set; }

        // Referência para o usuário avaliador
        public int AvaliadorId { get; set; }
        public User Avaliador { get; set; }

        // Referência para o usuário avaliado
        public int AvaliadoId { get; set; }
        public User Avaliado { get; set; }

        // Estrelas
        public int Star { get; set; }

        // Comentário
        public string? Comment { get; set; }
    }
}

