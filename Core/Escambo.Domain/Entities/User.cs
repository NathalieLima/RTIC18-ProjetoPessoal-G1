using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Escambo.Domain.Entities
{
    public sealed class User : BaseEntity
    {
        public int UserId { get; set; }
        public string? Name { get; set; } // Nome
        public required string? Email { get; set; } // Email
        public required string Password { get; set; } // Senha
        public required string? CPF { get; set; }
        public required string? RG { get; set; }
        public DateTime Birth { get; set; } // Aniversário
        public string? Address { get; set; } // Endereço
        public int Status { get; set; }
        public decimal Credit { get; set; } // Crédito
        public ICollection<Advertisement> Advertisements { get; } = new List<Advertisement>();

        // Avaliações como avaliador
        public ICollection<Avaluation>? AvaluationsAsAvaluator { get; set; }

        // Avaliações como avaliado
        public ICollection<Avaluation>? AvaluationsAsAvaluated { get; set; }
    }
}
