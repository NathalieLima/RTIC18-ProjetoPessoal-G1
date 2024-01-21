using Escambo.domain.Entities;
using Escambo.domain.Interface;

public interface IUserRepository : IBaseRepository<User>
{
    User FindByEmail(string email); //encontrar pelo email
    User FindByName(string name); //encontrar pelo nome
    void UpdatePassword(int userId, string newPassword); //atualizar a senha
    IEnumerable<User> GetAllActiveUsers(CancellationToken cancellationToken); //pegar todos os usuarios ativos
}

