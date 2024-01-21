using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Escambo.Domain.Entities
{
    public sealed class User : BaseEntity
    {
        public int UserId { get; set; }
        public string? Name { get; set; } // Nome
        [Required]
        public string? Email { get; set; } // Email
        [Required]
        public string Password { get; set; } // Senha
        [Required]
        public string? CPF { get; set; }
        [Required]
        public string? RG { get; set; }
        public DateTime Birth { get; set; } // Aniversário
        public string? Address { get; set; } // Endereço
        public int Status { get; set; }
        public decimal Credit { get; set; } // Crédito
        public ICollection<Advertisement> Advertisements { get; } = new List<Advertisement>();

        // Avaliações como avaliador
        public ICollection<Avaluation>? EvaluationsAsEvaluator { get; set; }

        // Avaliações como avaliado
        public ICollection<Avaluation>? EvaluationsAsEvaluated { get; set; }
    }
}
