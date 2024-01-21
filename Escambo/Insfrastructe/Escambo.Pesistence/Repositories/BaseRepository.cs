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

    public void Create(T entity){
       
       entity.Created = DateTime.UtcNow;
       _context.add(entity);
    
    }
    public void Update(T entity){
        entity.Updated = DateTime.UtcNow;
         _context.add(entity);
    }
    public void Delete(T entity){
        entity.Deleted = DateTime.UtcNow;
        _context.Remove(entity);
    }

    public async Task<IEnumerable<T>> GetAll(CancellationToken cancellationToken)
    {
        return await _context.Set<T>().ToListAsync(cancellationToken);
    }

    public async Task<T> GetById(int id)
    {
        
        return await _context.Set<T>().FindAsync(id);
    }
}