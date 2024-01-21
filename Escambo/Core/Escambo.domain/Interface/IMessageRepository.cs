using Escambo.domain.Entities;
namespace Escambo.domain.Interface;

public interface IMessageRepository : IBaseRepository<Message>
{
    Task<IEnumerable<Message>> GetAllMessagesByChatId(int chatId, CancellationToken cancellationToken);
}