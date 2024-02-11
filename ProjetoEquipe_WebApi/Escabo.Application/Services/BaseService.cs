using Escambo.Infra.Context;

namespace Escambo.Application.Services;
public class BaseServices
{
    protected readonly EscamboContext _context;

    public BaseServices(EscamboContext context){
        _context = context;
    }
    
}
