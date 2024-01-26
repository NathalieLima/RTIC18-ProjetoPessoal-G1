using Escambo.WebAPI.Infra.Data.Interfaces;
using Escambo.WebAPI.Model;

namespace Escambo.WebAPI.Infra.Data;
public class AvaliacoesDB : IAvaliacaoCollection
{
   private readonly List<Avaliacao> _avaliacoes = new List<Avaliacao>();
   private int _id = 0;

   public void Create(Avaliacao avaliacao)
   {
      if(_avaliacoes.Count > 0)
         _id = _avaliacoes.Max(m => m.AvaliacaoId);
      avaliacao.AvaliacaoId = ++_id;
      _avaliacoes.Add(avaliacao);
   }
   public void Delete(int id)
   {
      _avaliacoes.RemoveAll(m => m.AvaliacaoId == id);
   }
   public void GetAll()
   {
   
   }
   public void GetById(int id)
   {
   
   }
   public void Update(int id, Avaliacao avaliacao)
   {
      var avaliacaoDB = _avaliacoes.FirstOrDefault(m => m.AvaliacaoId == id);
      if(avaliacaoDB is not null)
      {
         avaliacaoDB.Star = avaliacao.Star;
      }
   }
}
