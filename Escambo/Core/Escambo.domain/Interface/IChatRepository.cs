using Escambo.domain.Entities;
namespace Escambo.domain.Interface;
public interface IChatRepository : IBaseRepository<Chat>
{
    Task<IEnumerable<Chat>> GetChatByServiceId(int serviceId, CancellationToken cancellationToken);

}