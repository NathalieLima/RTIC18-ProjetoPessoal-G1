using Microsoft.AspNetCore.Mvc;
using Escambo.WebAPI.Infra.Data.Interfaces;
using Escambo.WebAPI.Model;

namespace TechMed.WebAPI.Controllers;

[ApiController]
[Route("/api/v0.1/")]
public class MensagemController : ControllerBase
{
   [HttpGet("mensagens")]
   public IActionResult GetAll()
   {
      return NoContent();
   }

   [HttpGet("mensagem/{id}")]
   public IActionResult GetById(int id)
   {
      return NoContent();
   }

   [HttpPost("mensagem")]
   public IActionResult Post()
   {
      return NoContent();
   }

   [HttpPut("mensagem/{id}")]
   public IActionResult Put(int id)
   {
      //mensagem.MensagemId = id;
      return NoContent();
   }

   [HttpDelete("mensagem/{id}")]
   public IActionResult Delete(int id)
   {
      return NoContent();
   } 
}