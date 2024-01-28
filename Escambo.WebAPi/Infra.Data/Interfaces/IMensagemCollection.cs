using Escambo.WebAPI.Model;

namespace Escambo.WebAPI.Infra.Data.Interfaces;
public interface IMensagemCollection : IBaseCollection<Mensagem>
{  
    void Update(int id, Mensagem obj);
}