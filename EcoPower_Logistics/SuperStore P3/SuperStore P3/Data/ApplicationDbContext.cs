/*using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models;
using NuGet.Protocol.Core.Types;

namespace Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //define a DBSet for the product entity
        public DbSet<Product> Products { get; set; }

        // Repository Class
        public class ProductRepository
        {
            private readonly ApplicationDbContext _context;

            public ProductRepository(ApplicationDbContext context)
            {
                _context = context;
            }
            //Get All: Products
            public IEnumerable<Product> GetAll()
            {
                return _context.Products.ToList();
            }

        }
        // Controller/Service Class
        public class ProductService
        {
            private readonly ProductRepository _productRepository;

            public ProductService(ProductRepository productRepository)
            {
                _productRepository = productRepository;
            }

            public IEnumerable<Product> GetAllProducts()
            {
                return _productRepository.GetAll();
            }
        }
    }
}*/

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}