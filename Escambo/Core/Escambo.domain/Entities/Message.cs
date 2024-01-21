namespace Escambo.domain.Entities;
public sealed class Message: BaseEntity
{
    public string? Text { get; set; }
    public DateTime SendDate { get; set; }

    public int ChatId {get;set;}
    public required Chat Chat {get;set;}
}