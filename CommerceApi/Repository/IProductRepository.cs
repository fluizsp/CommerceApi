using System.Collections;
using System.Collections.Generic;
using CommerceApi.Models;

public interface IProductRepository : IRepository<Product>
{
    IEnumerable<Product> GetByPriceRange(int priceMin, int priceMax);
}