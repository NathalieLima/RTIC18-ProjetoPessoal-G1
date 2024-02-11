
using Escambo.Application.Model.ViewInput;
using Escambo.Application.Model.ViewOutput;
using Escambo.Application.Services.Interface;
using Escambo.Domain.Entities;
using Escambo.Infra.Context;

namespace Escambo.Application.Services;
public class LoginService : BaseServices, ILoginService
{
    
    public LoginService(EscamboContext context) : base(context)
    {}

    public int Creat(LoginViewInputModel TEntity)
    {
        var id = _context.Logins.Count() + 1;
        var login = new Login{
            LoginId= id,
            Username = TEntity.Email,
            Senha = TEntity.Senha
        };
        
        _context.Logins.Add(login);
        _context.SaveChanges();

        return id;
    }

    public LoginViewOutputModel Delete(int id)
    {
        throw new NotImplementedException();
    }

    public LoginViewOutputModel Get(int id)
    {
        throw new NotImplementedException();
    }

    public ICollection<LoginViewOutputModel> GetAll()
    {
        var login = _context.Logins.Select(x => new LoginViewOutputModel{
            LoginId = x.LoginId,
            Email = x.Username,
        });
        return login.ToList();
    }

    public LoginViewOutputModel Update(LoginViewOutputModel TEntity)
    {
        throw new NotImplementedException();
    }
    
}
