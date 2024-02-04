using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommerceApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CommerceApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;

        private static readonly Product[] SampleProducts = new[]{
            new Product{ProductId = 1, ProductName = "Smartphone", Price = 1200, Quantity = 100}
            ,new Product{ProductId = 2, ProductName = "Laptop", Price = 2000, Quantity = 50}
            ,new Product{ProductId = 3, ProductName = "Tablet", Price = 1000, Quantity = 200}
            ,new Product{ProductId = 4, ProductName = "Desktop", Price = 3000, Quantity = 10}
            ,new Product{ProductId = 5, ProductName = "Mouse", Price = 50, Quantity = 300}
            ,new Product{ProductId = 6, ProductName = "Keyboard", Price = 100, Quantity = 400}
        };
        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return SampleProducts;
        }

        [HttpGet("{ProductId}")]
        public Product Get(int ProductId){
            return SampleProducts.FirstOrDefault(p => p.ProductId == ProductId);
        }

        [HttpGet("ByPrice/{PriceMin}-{PriceMax}")]
        public IEnumerable<Product> GetByPrice(int PriceMin, int PriceMax){
            return SampleProducts.Where(p=> p.Price>PriceMin && p.Price<PriceMax);
        }

    }
}