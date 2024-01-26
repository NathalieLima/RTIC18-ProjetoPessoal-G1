using Escambo.WebAPI.Model;

namespace Escambo.WebAPI.Infra.Data.Interfaces;

public interface IAvaliacaoCollection : IBaseCollection<Avaliacao>
{
    void Update(int id, Avaliacao obj);
}
