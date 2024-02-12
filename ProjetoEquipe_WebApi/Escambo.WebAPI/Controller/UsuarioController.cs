using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escabo.Application.Model.ViewInput;
using Escabo.Application.Model.ViewOutput;
using Escabo.Application.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Escambo.WebAPI.Controller
{
    [ApiController]
    [Route("/api/v0.1/")]
    public class UsuarioController : ControllerBase
    {
        
        private readonly IUsuarioService _userService;
        public List<UsuarioViewModel> Users => _userService.GetAll();
        public UsuarioController(IUsuarioService service) => _userService = service;

        [HttpGet("usuarios")]
        public ActionResult<List<UsuarioViewModel>> GetAllUsers()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }
        [HttpGet("usuario/{id}")]
        public ActionResult<UsuarioViewModel> GetUserById(int id)
        {
            var user = _userService.GetById(id);
            if (user == null)
            {
                return NotFound(); // Retorna 404 se o usuário não for encontrado
            }
            return Ok(user);
        }
        [HttpPost("usuario")]
        public ActionResult<int> CreateUser(UsuarioInputModel usuarioInput)
        {
            try
            {
                var userId = _userService.Create(usuarioInput);
                return CreatedAtAction(nameof(GetUserById), new { id = userId }, userId);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); // Retorna 400 se houver um erro na criação do usuário
            }
        }
        [HttpPut("usuario/{id}")]
        public IActionResult UpdateUser(int id, UsuarioInputModel usuarioInput)
        {
            try
            {
                _userService.Update(id, usuarioInput);
                return NoContent(); // Retorna 204 (No Content) se a atualização for bem-sucedida
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); // Retorna 400 se houver um erro na atualização do usuário
            }
        }

        [HttpDelete("usuario/{id}")]
        public IActionResult DeleteUser(int id)
        {
            try
            {
                _userService.Delete(id);
                return NoContent(); // Retorna 204 (No Content) se a exclusão for bem-sucedida
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); // Retorna 400 se houver um erro na exclusão do usuário
            }
        }
    }
}