using System.Linq.Expressions;

namespace EcoPower_Logistics.Repository
{
    public interface IOrderRepositorye<Order> where Order : class
    {
        Order GetOrderById(int orderId);
        IEnumerable<Order> GetAll();
        IEnumerable<Order> Find(Expression<Func<Order, bool>> expression);
        void Add(Order entity);
        void AddRange(IEnumerable<Order> entities);
        void Remove(Order entity);
        void RemoveRange(IEnumerable<Order> entities);
    }
}
