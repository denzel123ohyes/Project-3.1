using System.Linq.Expressions;

namespace EcoPower_Logistics.Repository
{
    public interface IProductRepositorye<Product> where Product : class
    {
        Product GetProductById(int productId);
        IEnumerable<Product> GetAll();
        IEnumerable<Product> Find(Expression<Func<Product, bool>> expression);
        void Add(Product entity);
        void AddRange(IEnumerable<Product> entities);
        void Remove(Product entity);
        void RemoveRange(IEnumerable<Product> entities);

    }
}
