namespace Escambo.Pesistence.Repositories;
using Escambo.domain.Interface;
using Escambo.domain.Entities;
using Escambo.Pesistence.Context;
using System.Collections.Generic;
using System.Data;
using Microsoft.EntityFrameworkCore;

public class BaseRepository<T> : IBaseRepository<T> where T: BaseEntity
{

    protected readonly EscamboDBContext _context;

    public BaseRepository(EscamboDBContext context){
        _context = context;
    }

    // Creates a new entity in the database.
    // 
    // Parameters:
    //   entity: The entity to be created.

    //crea uma nova entidade
    
    public void Create(T entity){
    
       entity.Created = DateTime.UtcNow;
       _context.Add(entity);
    
    }
    public void Update(T entity){
        entity.Updated = DateTime.UtcNow;
         _context.Add(entity);
    }
    public void Delete(T entity){
        entity.Deleted = DateTime.UtcNow;
        _context.Remove(entity);
    }

  //retona uma entidade de forma assincrona com base no contexto do banco de dados
    public async Task<T> GetById(int id, CancellationToken cancellationToken)
    {
        
        return await _context.Set<T>().FindAsync(id);
    }


    //retorna uma lista de entidades
    public async Task<IEnumerable<T>> GetAll(CancellationToken cancellationToken)
    {
        return await _context.Set<T>().ToListAsync(cancellationToken);
    }

  
}