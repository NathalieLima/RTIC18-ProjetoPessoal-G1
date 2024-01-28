using Escambo.WebAPI.Model;

namespace Escambo.WebAPI.Infra.Data.Interfaces;
public interface IBaseCollection<T>
{  
   void Create(T obj);
   ICollection<T> GetAll();
   T? GetById(int id);
   void Delete(int id);
}