using Escambo.WebAPI.Model;

namespace Escambo.WebAPI.Infra.Data.Interfaces;
public interface IChatCollection : IBaseCollection<Chat>
{  
    ICollection<Mensagem> ChatGetAllMensagens();
}