using System;
using System.Collections.Generic;
using System.Linq;
using CommerceApi.Models;
using Microsoft.EntityFrameworkCore;

public class DbProductRepository : DbRepository<Product>, IProductRepository
{
    private DbSet<Product> dbProducts;

    public DbProductRepository(ApplicationDbContext context) : base(context)
    {
        dbProducts = _context.Set<Product>();
    }

    public IEnumerable<Product> GetByPriceRange(int priceMin, int priceMax)
    {
        return dbProducts.Where(p => p.Price >= priceMin && p.Price <= priceMax);
    }

}