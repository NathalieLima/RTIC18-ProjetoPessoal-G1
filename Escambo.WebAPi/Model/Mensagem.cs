namespace Escambo.WebAPI.Model;
public sealed class Mensagem 
{
    
    public int MensagemId { get; set; }
    public string? Texto { get; set; }
    public DateTime DataEnvio { get; set; } //data de envio
    public DateTime HoraEnvio { get; set;} //hora de envio
    public int ConversaId {get;set;}
    public required Conversa Conversa {get;set;}
}
