using Escambo.Application.Model.ViewInput;
using Escambo.Application.Model.ViewOutput;
using Escambo.Application.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Escambo.WebAPI.Controller;

[ApiController]
[Route("Login")]
public class LoginController:ControllerBase
{

    private readonly ILoginService _loginService;
    

    public LoginController(ILoginService loginService)
    {
        _loginService = loginService;
    }
    
    [HttpGet]
    public IActionResult GetAll()
    {
        var _logins = _loginService.GetAll();
        if (_logins is not null)
            return Ok(_logins);

        return NotFound("Logins não encontrado");
    }
    [HttpPost]
    public IActionResult Post(LoginViewInputModel login)
    {
        var id = _loginService.Creat(login);
        if (id == 0)
            return BadRequest("Login não criado");
        return Ok("Login criado");
    }
    
}