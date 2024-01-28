using Microsoft.AspNetCore.Mvc;
using Escambo.WebAPI.Infra.Data.Interfaces;
using Escambo.WebAPI.Model;

namespace TechMed.WebAPI.Controllers;

[ApiController]
[Route("/api/v0.1/")]
public class AvaliacaoController : ControllerBase
{
   [HttpGet("avaliacoes")]
   public IActionResult GetAll()
   {
      return NoContent();
   }

   [HttpGet("avaliacao/{id}")]
   public IActionResult GetById(int id)
   {
      return NoContent();
   }

   [HttpPost("avaliacao")]
   public IActionResult Post([FromBody] Avaliacao avaliacao)
   {
      return Ok(avaliacao);
   }

   [HttpPut("avaliacao/{id}")]
   public IActionResult Put(int id, [FromBody] Avaliacao avaliacao)
   {
      avaliacao.AvaliacaoId = id;
      return Ok(avaliacao);
   }

   [HttpDelete("avaliacao/{id}")]
   public IActionResult Delete(int id)
   {
      return NoContent();
   }
   [HttpGet("avaliacao/{id}/prestacoes")]
   public IActionResult GetAllPrestacoes(int id)
   {
      return NoContent();
   }
}
