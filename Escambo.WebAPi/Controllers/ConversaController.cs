using Microsoft.AspNetCore.Mvc;
using Escambo.WebAPI.Infra.Data.Interfaces;
using Escambo.WebAPI.Model;

namespace TechMed.WebAPI.Controllers;

[ApiController]
[Route("/api/v0.1/")]
public class ConversaController : ControllerBase
{

   //Entende-se por conversa os chats entre os usuários
   [HttpGet("conversas")]

   public IActionResult GetAll() // retorna todos os chats.
   {
      return NoContent();
   }

   [HttpGet("conversa/{id}")] //retronar uma conversa especifica
   public IActionResult GetById(int id)
   {
      return NoContent();
   }

   [HttpPost("conversa")] //criar uma conversa requisito para criar uma conversa ter 2 usuários
   public IActionResult Post()
   {
      return NoContent();
   }

   [HttpDelete("conversa/{id}")] //Ao inves de apagar seria interressante encerrar o chat e arquivar a conversa
   public IActionResult Delete(int id)
   {
      return NoContent();
   }

   [HttpGet("conversa/{id}/mensagens")] //retonar todas as messagens referentes a uma conversa
   public IActionResult GetAllMensagens(int id)
   {
      return NoContent();
   }
}