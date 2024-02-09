using CommerceApi.Controllers;
using CommerceApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NSubstitute;
using System;
using System.Linq;
using Xunit;

namespace CommerceApi.UnitTest
{
    public class ProductTests
    {
        private readonly IProductRepository _productRepository = Substitute.For<IProductRepository>();
        private readonly ILogger<ProductController> _logger = Substitute.For<ILogger<ProductController>>();
        private static readonly Product[] _sampleProducts = new[]{
            new Product{ProductId = 1, ProductName = "Smartphone", Price = 1200, Quantity = 100}
            ,new Product{ProductId = 2, ProductName = "Laptop", Price = 2000, Quantity = 50}
            ,new Product{ProductId = 5, ProductName = "Mouse", Price = 50, Quantity = 300}
            ,new Product{ProductId = 6, ProductName = "Keyboard", Price = 100, Quantity = 400}
        };
        [Fact]
        public void GetAll()
        {
            //Arrange
            _productRepository.GetAll().Returns(_sampleProducts);
            var productController = new ProductController(_logger, _productRepository);
            //Act
            var products = productController.Get();

            //Assert
            Assert.Equal(products.Count(), _sampleProducts.Length);

        }

        [Fact]
        public void GetById()
        {
            //Arrange
            _productRepository.GetById(1).Returns(_sampleProducts.FirstOrDefault(p => p.ProductId == 1));
            var productController = new ProductController(_logger, _productRepository);
            //Act
            var product = productController.Get(1);
            //Assert
            Assert.Equal("Smartphone", product.ProductName);
        }

        [Fact]
        public void GetByPrice()
        {
            //Arrange
            _productRepository.GetByPriceRange(500, 1200).Returns(_sampleProducts.Where(p => p.Price >= 500 && p.Price <= 1200));
            var productController = new ProductController(_logger, _productRepository);
            //Act
            var products=productController.GetByPrice(500, 1200);
            //Assert
            Assert.Single(products);
        }

    }
}
