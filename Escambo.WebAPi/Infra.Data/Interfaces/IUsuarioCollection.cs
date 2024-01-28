using Escambo.WebAPI.Model;

namespace Escambo.WebAPI.Infra.Data.Interfaces;
public interface IUsuarioCollection : IBaseCollection<Usuario>
{  
    void Update(int id, Usuario obj);
    ICollection<Chat> UsuarioGetAllChats();
    ICollection<Anuncio> UsuarioGetAllAnuncios();
    ICollection<PrestacaoServico> UsuarioGetAllPrestacoes();
}