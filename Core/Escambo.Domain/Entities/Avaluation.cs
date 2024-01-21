namespace Escambo.Domain.Entities;

public sealed class Avaluation: BaseEntity //avaliação
{

    // anuncio referencia para o entity criar o relacionamento
    public int PosterId { get; set; } 
    public required Poster Poster { get; set; } 

    //Usuario
    public int UserId { get; set; }
    public required User User { get; set; }

    // estrelas
    public int Star { get; set; }

    //comentario
    public string? Comment { get; set; }
 
}