using Microsoft.AspNetCore.Mvc;
using Escambo.WebAPI.Infra.Data.Interfaces;
using Escambo.WebAPI.Model;

namespace TechMed.WebAPI.Controllers;

[ApiController]
[Route("/api/v0.1/")]
public class ChatController : ControllerBase
{
   [HttpGet("chats")]
   public IActionResult GetAll()
   {
      return NoContent();
   }

   [HttpGet("chat/{id}")]
   public IActionResult GetById(int id)
   {
      return NoContent();
   }

   [HttpPost("chat")]
   public IActionResult Post([FromBody] Chat chat)
   {
      return Ok(chat);
   }

   [HttpDelete("chat/{id}")]
   public IActionResult Delete(int id)
   {
      return NoContent();
   }

   [HttpGet("chat/{id}/mensagens")]
   public IActionResult GetAllMensagens(int id)
   {
      return NoContent();
   }
}