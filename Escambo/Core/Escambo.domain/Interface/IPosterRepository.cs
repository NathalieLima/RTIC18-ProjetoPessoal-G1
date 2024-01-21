using Escambo.domain.Entities;
namespace Escambo.domain.Interface;

public interface IPosterRepository : IBaseRepository<Poster> {

    Task<IEnumerable<Poster>> GetAllPosterByUserId(int userId, CancellationToken cancellationToken);
} 