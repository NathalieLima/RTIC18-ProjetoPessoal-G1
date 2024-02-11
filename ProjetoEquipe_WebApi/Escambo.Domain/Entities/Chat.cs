namespace Escambo.Domain.Entities;
public class Chat
{
    public int ChatId { get; set; }

    public int PrestacaoServicoId { get; set; }
    public PrestacaoServico? PrestacaoServico { get; set; }
    ICollection<Usuario>? Usuarios { get; set; } 
    public ICollection<Mensagem>? Mensagens { get; set; }
}
