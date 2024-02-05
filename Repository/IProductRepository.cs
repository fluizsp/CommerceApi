using System.Collections;
using System.Collections.Generic;
using CommerceApi.Models;

public interface IProductRepository
{
    IEnumerable<Product> GetAll();
    Product GetById(int id);
    void Add(Product entity);
    void Update(Product entity);
    void Delete(Product entity);
    IEnumerable<Product> GetByPriceRange(int priceMin, int priceMax);
}