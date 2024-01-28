using Escambo.WebAPI.Infra.Data.Interfaces;
using Escambo.WebAPI.Model;

namespace Escambo.WebAPI.Infra.Data;
public class ChatsDB : IChatCollection
{
   private readonly List<Chat> _chats = new List<Chat>();
   private int _id = 0;

   public void Create(Chat chat)
   {
      if(_chats.Count > 0)
         _id = _chats.Max(m => m.ChatId);
      chat.ChatId = ++_id;
      _chats.Add(chat);
   }
   public void Delete(int id)
   {
      _chats.RemoveAll(m => m.ChatId == id);
   }
   public ICollection<Chat> GetAll()
   {
      return _chats.ToArray();
   }
   public Chat? GetById(int id)
   {
      return _chats.FirstOrDefault(m => m.ChatId == id);
   }
   public ICollection<Mensagem> ChatGetAllMensagens()
   {
      List<Mensagem> mensagens = new List<Mensagem>();
      return mensagens;
   }
}
