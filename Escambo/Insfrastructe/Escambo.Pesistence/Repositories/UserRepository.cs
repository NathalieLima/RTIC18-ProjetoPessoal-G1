using Escambo.domain.Entities;

using Escambo.domain.Interface;
using Microsoft.EntityFrameworkCore;

namespace Escambo.Pesistence.Repositories;

using Escambo.Pesistence.Context;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(EscamboDBContext context) : base(context){}

    public async Task<User> FindByEmail(string email, CancellationToken cancellationToken)
    {
        return await _context.Users.FirstOrDefaultAsync(x => x.Email == email);
    }



    public async Task<User> FindByName(string name, CancellationToken cancellationToken)
    {
       return await _context.Users.FirstOrDefaultAsync(x => x.Name == name);
    }

    public async Task<IEnumerable<User>> GetAllActiveUsers(CancellationToken cancellationToken)
    {
        return await _context.Users.Where(x => x.Status == 1).ToListAsync(cancellationToken);
    }

    public void UpdatePassword(int userId, string newPassword, CancellationToken cancellationToken)
    {
        var user = _context.Users.FirstOrDefault(x => x.Id == userId);
        user.Password = newPassword;
        _context.Update(user);
    }
}