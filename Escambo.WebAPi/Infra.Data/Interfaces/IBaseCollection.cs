using Escambo.WebAPI.Model;

namespace Escambo.WebAPI.Infra.Data.Interfaces;
public interface IBaseCollection<T>
{  
   void Create(T obj);
   void GetAll();
   //ICollection<T> GetAll();
   void GetById(int id);
   //T? GetById(int id);
   //void Update(int id, T obj);
   void Delete(int id);
}