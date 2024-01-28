using Escambo.WebAPI.Infra.Data.Interfaces;
using Escambo.WebAPI.Model;

namespace Escambo.WebAPI.Infra.Data;
public class MensagensDB : IMensagemCollection
{
   private readonly List<Mensagem> _mensagens = new List<Mensagem>();
   private int _id = 0;

   public void Create(Mensagem mensagem)
   {
      if(_mensagens.Count > 0)
         _id = _mensagens.Max(m => m.MensagemId);
      mensagem.MensagemId = ++_id;
      _mensagens.Add(mensagem);
   }
   public void Delete(int id)
   {
      _mensagens.RemoveAll(m => m.MensagemId == id);
   }
   public ICollection<Mensagem> GetAll()
   {
      return _mensagens.ToArray();
   }
   public Mensagem? GetById(int id)
   {
      return _mensagens.FirstOrDefault(m => m.MensagemId == id);
   }
   public void Update(int id, Mensagem mensagem)
   {
      var mensagemDB = _mensagens.FirstOrDefault(m => m.MensagemId == id);
      if(mensagemDB is not null)
      {
         mensagemDB.Texto = mensagem.Texto;
      }
   }
}
