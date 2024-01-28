using Microsoft.AspNetCore.Mvc;
using Escambo.WebAPI.Infra.Data.Interfaces;
using Escambo.WebAPI.Model;

namespace TechMed.WebAPI.Controllers;

[ApiController]
[Route("/api/v0.1/")]
public class AnuncioController : ControllerBase
{
   [HttpGet("anuncios")]
   public IActionResult GetAll()
   {
      return NoContent();
   }

   [HttpGet("anuncio/{id}")]
   public IActionResult GetById(int id)
   {
      return NoContent();
   }

   [HttpPost("anuncio")]
   public IActionResult Post([FromBody] Anuncio anuncio)
   {
      return Ok(anuncio);
   }

   [HttpPut("anuncio/{id}")]
   public IActionResult Put(int id, [FromBody] Anuncio anuncio)
   {
      anuncio.AnuncioId = id;
      return Ok(anuncio);
   }

   [HttpDelete("anuncio/{id}")]
   public IActionResult Delete(int id)
   {
      return NoContent();
   }
   [HttpGet("anuncio/{id}/prestacoes")]
   public IActionResult GetAllPrestacoes(int id)
   {
      return NoContent();
   }
}
