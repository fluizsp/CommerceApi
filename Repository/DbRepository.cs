using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

public class DbRepository<T> : IRepository<T> where T : class
{
    public readonly ApplicationDbContext _context;
    private DbSet<T> entities;

    public DbRepository(ApplicationDbContext context)
    {
        _context = context;
        entities = _context.Set<T>();
    }
    public void Add(T entity)
    {
        if(entity == null) throw new ArgumentNullException(nameof(entity));
        entities.Add(entity);
        _context.SaveChanges();
    }

    public void Delete(T entity)
    {
        if(entity == null) throw new ArgumentNullException(nameof(entity));
        entities.Remove(entity);
        _context.SaveChanges();        
    }

    public IEnumerable<T> GetAll()
    {
        return entities.ToList();
    }

    public T GetById(int id)
    {
        return entities.Find(id);
    }

    public void Update(T entity)
    {
        if(entity == null) throw new ArgumentNullException(nameof(entity));
        entities.Update(entity);
        _context.SaveChanges();
    }
}