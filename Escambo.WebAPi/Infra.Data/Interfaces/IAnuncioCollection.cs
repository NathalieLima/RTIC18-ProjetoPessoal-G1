using Escambo.WebAPI.Model;

namespace Escambo.WebAPI.Infra.Data.Interfaces;

public interface IAnuncioCollection : IBaseCollection<Anuncio>
{
    void Update(int id, Anuncio obj);
    void AnuncioGetAllPrestacoes();
}
