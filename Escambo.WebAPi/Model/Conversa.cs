using Escambo.WebAPi.Model;

namespace Escambo.WebAPI.Model;
public class Conversa
{

    public int ConversaId { get; set; }
    public DateTime DataHoraInicio { get; set; } 
    public DateTime DataHoraFim { get; set; } 

    ICollection<Mensagem>? Mensagens { get; set; }
    public ICollection<ConversasHasUsuarios>? ConversasHasUsuarios { get; set; }
}
