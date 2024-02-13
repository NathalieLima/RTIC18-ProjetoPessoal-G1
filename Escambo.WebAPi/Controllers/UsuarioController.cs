using Microsoft.AspNetCore.Mvc;
using Escambo.WebAPI.Infra.Data.Interfaces;
using Escambo.WebAPI.Model;
using System;
using System.Linq;

namespace TechMed.WebAPI.Controllers;

[ApiController]
[Route("/api/v0.1/")]
public class UsuarioController : ControllerBase
{
    [HttpGet("usuarios")]
    public IActionResult GetAll()
    {
        var usuarios = Enumerable.Range(1, 5).Select(index => new Usuario
        {
            UsuarioId = index,
            Nome = $"Usuário {index}",
            Email = $"usuario{index}@exemplo.com",
        }).ToArray();

        return Ok(usuarios);
    }

    [HttpGet("usuario/{id}")]
    public IActionResult GetById(int id)
    {
        return NoContent();
    }

    [HttpPost("usuario")]
    public IActionResult Post([FromBody] Usuario usuario)
    {
        return Ok(usuario);
    }

    [HttpPut("usuario/{id}")]
    public IActionResult Put(int id, [FromBody] Usuario usuario)
    {
        usuario.UsuarioId = id;
        return Ok(usuario);
    }

    [HttpDelete("usuario/{id}")]
    public IActionResult Delete(int id)
    {
        return NoContent();
    }
    
    [HttpGet("usuario/{id}/conversas")]
    public IActionResult GetAllConversas(int id)
    {
        return NoContent();
    }
    
    [HttpGet("usuario/{id}/anuncios")]
    public IActionResult GetAllAnuncios(int id)
    {
        return NoContent();
    }
    
    [HttpGet("usuario/{id}/prestacoes")]
    public IActionResult GetAllPrestacoes(int id)
    {
        return NoContent();
    }
}

   /*
   //private readonly IUsuarioCollection _usuarios;
   public List<Usuario> Usuarios => _usuarios.GetAll().ToList();
   //public UsuarioController(IDatabaseFake dbFake) => _usuarios = dbFake.UsuariosCollection;

   [HttpGet("usuarios")]
   public IActionResult Get()
   {
      return Ok(Usuarios);
   }

   [HttpGet("usuario/{id}")]
   public IActionResult GetById(int id)
   {
      var usuario = _usuarios.GetById(id);
      return Ok(usuario);
   }

   [HttpPost("usuario")]
   public IActionResult Post([FromBody] Usuario usuario)
   {
      _usuarios.Create(usuario);
      return CreatedAtAction(nameof(Get), usuario);
 
   }

   [HttpPut("usuario/{id}")]
   public IActionResult Put(int id, [FromBody] Usuario usuario)
   {
      if (_usuarios.GetById(id) == null)
         return NoContent();
      _usuarios.Update(id, usuario);
      return Ok(_usuarios.GetById(id));
   }

   [HttpDelete("usuario/{id}")]
   public IActionResult Delete(int id)
   {
      if (_usuarios.GetById(id) == null)
         return NoContent();
      _usuarios.Delete(id);
      return Ok();
   }
   */