using Escambo.WebAPI.Infra.Data.Interfaces;
using Escambo.WebAPI.Model;

namespace Escambo.WebAPI.Infra.Data;
public class AnunciosDB : IAnuncioCollection
{
   private readonly List<Anuncio> _anuncios = new List<Anuncio>();
   private int _id = 0;

   public void Create(Anuncio anuncio)
   {
      if(_anuncios.Count > 0)
         _id = _anuncios.Max(m => m.AnuncioId);
      anuncio.AnuncioId = ++_id;
      _anuncios.Add(anuncio);
   }
   public void Delete(int id)
   {
      _anuncios.RemoveAll(m => m.AnuncioId == id);
   }
   public void GetAll()
   {
   
   }
   public void GetById(int id)
   {
   
   }
   public void Update(int id, Anuncio anuncio)
   {
      var anuncioDB = _anuncios.FirstOrDefault(m => m.AnuncioId == id);
      if(anuncioDB is not null)
      {
         anuncioDB.Nome = anuncio.Nome;
      }
   }
   public void AnuncioGetAllPrestacoes()
   {

   }
}
