using Escambo.WebAPI.Model;

namespace Escambo.WebAPI.Infra.Data.Interfaces;
public interface IPrestacaoCollection : IBaseCollection<PrestacaoServico>
{  
    void Update(int id, PrestacaoServico obj);
    ICollection<Avaliacao> PrestacaoGetAllAvaliacoes();
}