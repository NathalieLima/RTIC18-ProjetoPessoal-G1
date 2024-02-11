namespace Escambo.Domain.Entities;
public class Mensagem
{
    public int MensagemId { get; set; }
    public string? Texto { get; set; }
    public DateTimeOffset DataHora { get; set; }
    public ICollection<Chat>? Chats { get; set; }

}
