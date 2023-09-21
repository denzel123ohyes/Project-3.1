
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using EcoPower_Logistics.Repository;
using Data;

namespace EcoPower_Logistics.Repository
{
    public class ProductRepository : IProductRepositorye<Product>
    {
        private readonly SuperStoreContext _context;

        public ProductRepository(SuperStoreContext context)
        {
            _context = context;
        }

        public Product GetProductById(int productId)
        {
            return _context.Products.Find(productId);
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public IEnumerable<Product> Find(Expression<Func<Product, bool>> expression)
        {
            return _context.Products.Where(expression);
        }

        public void Add(Product entity)
        {
            _context.Products.Add(entity);
        }

        public void AddRange(IEnumerable<Product> entities)
        {
            _context.Products.AddRange(entities);
        }

        public void Remove(Product entity)
        {
            _context.Products.Remove(entity);
        }

        public void RemoveRange(IEnumerable<Product> entities)
        {
            _context.Products.RemoveRange(entities);
        }
    }

    public class ProductController : Controller
    {
        private readonly IProductRepositorye<Product> _productRepository;

        public ProductController(IProductRepositorye<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        // GET: Product
        public IActionResult Index()
        {
            var results = _productRepository.GetAll();
            return View(results);
        }
    }
}
