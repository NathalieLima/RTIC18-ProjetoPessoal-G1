using Escambo.WebAPI.Infra.Data.Interfaces;
using Escambo.WebAPI.Model;

namespace Escambo.WebAPI.Infra.Data;
public class UsuariosDB : IUsuarioCollection
{
   private readonly List<Usuario> _usuarios = new List<Usuario>();
   private int _id = 0;

   public void Create(Usuario usuario)
   {
      if(_usuarios.Count > 0)
         _id = _usuarios.Max(m => m.UsuarioId);
      usuario.UsuarioId = ++_id;
      _usuarios.Add(usuario);
   }
   public void Delete(int id)
   {
      _usuarios.RemoveAll(m => m.UsuarioId == id);
   }
   public ICollection<Usuario> GetAll()
   {
      return _usuarios.ToArray();
   }
   public Usuario? GetById(int id)
   {
      return _usuarios.FirstOrDefault(m => m.UsuarioId == id);
   }
   public void Update(int id, Usuario usuario)
   {
      var usuarioDB = _usuarios.FirstOrDefault(m => m.UsuarioId == id);
      if(usuarioDB is not null)
      {
         usuarioDB.Nome = usuario.Nome;
      }
   }
   public ICollection<Conversa> UsuarioGetAllConversas()
   {
      List<Conversa> conversas = new List<Conversa>();
      return conversas;
   }
   public ICollection<Anuncio> UsuarioGetAllAnuncios()
   {
      List<Anuncio> anuncios = new List<Anuncio>();
      return anuncios;
   }
   public ICollection<PrestacaoServico> UsuarioGetAllPrestacoes()
   {
      List<PrestacaoServico> prestacoes = new List<PrestacaoServico>();
      return prestacoes;
   }
}
