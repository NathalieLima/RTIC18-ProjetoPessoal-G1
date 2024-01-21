namespace Escambo.domain.Entities;

public sealed class Poster: BaseEntity{
    
    public int UserId { get; set; }
    public required User User {get; set;}

    public int ServiceId { get; set; }
    public required Service Service { get; set; }    
}