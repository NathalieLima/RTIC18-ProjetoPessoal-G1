using Escambo.WebAPI.Model;

namespace Escambo.WebAPI.Infra.Data.Interfaces;
public interface IConversaCollection : IBaseCollection<Conversa>
{  
    ICollection<Mensagem> ConversaGetAllMensagens();
}