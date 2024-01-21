using Escambo.domain.Entities;
using Escambo.domain.Interface;

public interface IUserRepository : IBaseRepository<User>
{
    Task<User> FindByEmail(string email, CancellationToken cancellationToken); //encontrar pelo email
    Task<User> FindByName(string name, CancellationToken  cancellationToken); //encontrar pelo nome
    void UpdatePassword(int userId, string newPassword, CancellationToken cancellationToken); //atualizar a senha
    Task<IEnumerable<User>> GetAllActiveUsers(CancellationToken cancellationToken); //pegar todos os usuarios ativos
}

