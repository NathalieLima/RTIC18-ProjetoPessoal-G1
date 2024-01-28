using Escambo.WebAPI.Infra.Data.Interfaces;
using Escambo.WebAPI.Model;

namespace Escambo.WebAPI.Infra.Data;
public class PrestacoesDB : IPrestacaoCollection
{
   private readonly List<PrestacaoServico> _prestacoes = new List<PrestacaoServico>();
   private int _id = 0;

   public void Create(PrestacaoServico prestacao)
   {
      if(_prestacoes.Count > 0)
         _id = _prestacoes.Max(m => m.PrestacaoId);
      prestacao.PrestacaoId = ++_id;
      _prestacoes.Add(prestacao);
   }
   public void Delete(int id)
   {
      _prestacoes.RemoveAll(m => m.PrestacaoId == id);
   }
   public ICollection<PrestacaoServico> GetAll()
   {
      return _prestacoes.ToArray();
   }
   public PrestacaoServico? GetById(int id)
   {
      return _prestacoes.FirstOrDefault(m => m.PrestacaoId == id);
   }
   public void Update(int id, PrestacaoServico prestacao)
   {
      var prestacaoDB = _prestacoes.FirstOrDefault(m => m.PrestacaoId == id);
      if(prestacaoDB is not null)
      {
         prestacaoDB.Duração = prestacao.Duração;
      }
   }
   public ICollection<Avaliacao> PrestacaoGetAllAvaliacoes()
   {
      List<Avaliacao> avaliacoes = new List<Avaliacao>();
      return avaliacoes;
   }
}
