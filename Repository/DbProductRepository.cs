using System;
using System.Collections.Generic;
using System.Linq;
using CommerceApi.Models;
using Microsoft.EntityFrameworkCore;

public class DbProductRepository : IProductRepository
{
    public readonly ApplicationDbContext _context;
    private DbSet<Product> dbProducts;

    public DbProductRepository(ApplicationDbContext context)
    {
        _context = context;
        dbProducts = _context.Set<Product>();
    }
    public void Add(Product entity)
    {
        if (entity == null) throw new ArgumentNullException(nameof(entity));
        dbProducts.Add(entity);
        _context.SaveChanges();
    }

    public void Delete(Product entity)
    {
        if (entity == null) throw new ArgumentNullException(nameof(entity));
        dbProducts.Remove(entity);
        _context.SaveChanges();
    }

    public IEnumerable<Product> GetAll()
    {
        return dbProducts.ToList();
    }

    public Product GetById(int id)
    {
        return dbProducts.Find(id);
    }

    public IEnumerable<Product> GetByPriceRange(int priceMin, int priceMax)
    {
        return dbProducts.Where(p => p.Price >= priceMin && p.Price <= priceMax);
    }

    public void Update(Product entity)
    {
        if (entity == null) throw new ArgumentNullException(nameof(entity));
        dbProducts.Update(entity);
        _context.SaveChanges();
    }
}