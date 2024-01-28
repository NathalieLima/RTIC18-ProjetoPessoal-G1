using Microsoft.AspNetCore.Mvc;
using Escambo.WebAPI.Infra.Data.Interfaces;
using Escambo.WebAPI.Model;

namespace TechMed.WebAPI.Controllers;

[ApiController]
[Route("/api/v0.1/")]
public class PrestacaoController : ControllerBase
{
   [HttpGet("prestacoes")]
   public IActionResult GetAll()
   {
      return NoContent();
   }

   [HttpGet("prestacao/{id}")]
   public IActionResult GetById(int id)
   {
      return NoContent();
   }

   [HttpPost("prestacao")]
   public IActionResult Post()
   {
      return NoContent();
   }

   [HttpPut("prestacao/{id}")]
   public IActionResult Put(int id)
   {
      return NoContent();
   }

   [HttpDelete("prestacao/{id}")]
   public IActionResult Delete(int id)
   {
      return NoContent();
   }
   [HttpGet("prestacao/{id}/avaliacoes")]
   public IActionResult GetAllAvaliacoes(int id)
   {
      return NoContent();
   }
}