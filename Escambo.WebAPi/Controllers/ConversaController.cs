using Microsoft.AspNetCore.Mvc;
using Escambo.WebAPI.Infra.Data.Interfaces;
using Escambo.WebAPI.Model;

namespace TechMed.WebAPI.Controllers;

[ApiController]
[Route("/api/v0.1/")]
public class ConversaController : ControllerBase
{
   [HttpGet("conversas")]
   public IActionResult GetAll()
   {
      return NoContent();
   }

   [HttpGet("conversa/{id}")]
   public IActionResult GetById(int id)
   {
      return NoContent();
   }

   [HttpPost("conversa")]
   public IActionResult Post()
   {
      return NoContent();
   }

   [HttpDelete("conversa/{id}")]
   public IActionResult Delete(int id)
   {
      return NoContent();
   }

   [HttpGet("conversa/{id}/mensagens")]
   public IActionResult GetAllMensagens(int id)
   {
      return NoContent();
   }
}