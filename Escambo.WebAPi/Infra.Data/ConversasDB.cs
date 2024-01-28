using Escambo.WebAPI.Infra.Data.Interfaces;
using Escambo.WebAPI.Model;

namespace Escambo.WebAPI.Infra.Data;
public class ConversasDB : IConversaCollection
{
   private readonly List<Conversa> _conversas = new List<Conversa>();
   private int _id = 0;

   public void Create(Conversa conversa)
   {
      if(_conversas.Count > 0)
         _id = _conversas.Max(m => m.ConversaId);
      conversa.ConversaId = ++_id;
      _conversas.Add(conversa);
   }
   public void Delete(int id)
   {
      _conversas.RemoveAll(m => m.ConversaId == id);
   }
   public ICollection<Conversa> GetAll()
   {
      return _conversas.ToArray();
   }
   public Conversa? GetById(int id)
   {
      return _conversas.FirstOrDefault(m => m.ConversaId == id);
   }
   public ICollection<Mensagem> ConversaGetAllMensagens()
   {
      List<Mensagem> mensagens = new List<Mensagem>();
      return mensagens;
   }
}
