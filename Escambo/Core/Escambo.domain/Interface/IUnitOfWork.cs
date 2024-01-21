using Escambo.domain.Entities;
namespace Escambo.domain.Interface;
public interface IUnitOfWork{

    Task Commit(CancellationToken cancellationToken);
}