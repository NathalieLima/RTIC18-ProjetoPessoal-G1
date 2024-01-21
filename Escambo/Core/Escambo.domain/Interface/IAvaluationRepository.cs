using Escambo.domain.Entities;
namespace Escambo.domain.Interface;

public interface IAvaluationRepository : IBaseRepository<Avaluation>
{
    Task<IEnumerable<Avaluation>> GetAllAvaluationsByPosterId(int posterId, CancellationToken cancellationToken);
    
}