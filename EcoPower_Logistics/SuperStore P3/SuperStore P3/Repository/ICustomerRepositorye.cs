using Models;
using System.Linq.Expressions;

namespace EcoPower_Logistics.Repository
{
    public interface ICustomerRepositorye<Customer> where Customer : class
    {
        Customer GetOrderById(int customerId);
        IEnumerable<Customer> GetAll();
        IEnumerable<Customer> Find(Expression<Func<Customer, bool>> expression);
        void Add(Customer entity);
        void AddRange(IEnumerable<Customer> entities);
        void Remove(Customer entity);
        void RemoveRange(IEnumerable<Customer> entities);
    }
}
