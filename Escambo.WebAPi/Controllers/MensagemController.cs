using Microsoft.AspNetCore.Mvc;
using Escambo.WebAPI.Infra.Data.Interfaces;
using Escambo.WebAPI.Model;

namespace TechMed.WebAPI.Controllers;

[ApiController]
[Route("/api/v0.1/")]
public class MensagemController : ControllerBase
{
   [HttpGet("mensagens")] //retorna todas as messagens independente do chat
   public IActionResult GetAll()
   {
      return NoContent();
   }

   [HttpGet("mensagem/{id}")]//retorna uma mensagem especifica
   public IActionResult GetById(int id)
   {
      return NoContent();
   }

   //mensagem/chat/{id} atendendo ao requisito de criaçao de uma messagem
   [HttpPost("mensagem")] //criar uma mensagem requsito passar o id do chat 
   public IActionResult Post()
   {
      return NoContent();
   }

   [HttpPut("mensagem/{id}")]//pode editar uma mensgem enviada?
   public IActionResult Put(int id)
   {
      //mensagem.MensagemId = id;
      return NoContent();
   }

   [HttpDelete("mensagem/{id}")] //deletar uma mensagem, vai permitir apagar o registro da mensagem? talvez seja importante preservar para apuração futuras
   public IActionResult Delete(int id)
   {
      return NoContent();
   } 
}