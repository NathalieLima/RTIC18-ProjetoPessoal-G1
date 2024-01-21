using Escambo.domain.Entities;
namespace Escambo.domain.Interface;

public interface IBaseRepository<T> where T : BaseEntity
{

   
    void Create(T entity); 
    void Update(T entity);
    void Delete(T entity);
    Task<T> GetById(int id, CancellationToken cancellationToken); //pegar por id
    Task<IEnumerable<T>> GetAll(CancellationToken cancellationToken); //pegar todos

}