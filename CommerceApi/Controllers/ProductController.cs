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

        private readonly IProductRepository _productRepository;
        
        public ProductController(ILogger<ProductController> logger, IProductRepository productRepository)
        {
            _logger = logger;
            _productRepository = productRepository;
        }
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productRepository.GetAll();
        }

        [HttpGet("{ProductId}")]
        public Product Get(int ProductId){
            return _productRepository.GetById(ProductId);
        }

        [HttpGet("ByPrice/{PriceMin}-{PriceMax}")]
        public IEnumerable<Product> GetByPrice(int PriceMin, int PriceMax){
            return _productRepository.GetByPriceRange(PriceMin,PriceMax);
        }

    }
}