
using System.Linq.Expressions;
using System.Threading.Tasks; // Add this using statement for Task
using Microsoft.AspNetCore.Mvc;
using Models;
using EcoPower_Logistics.Repository; // Add the namespace of your interface
using Data;

namespace EcoPower_Logistics.Repository
{
    public class OrderRepository : IOrderRepositorye<Order>
    {
        private readonly SuperStoreContext _context;

        public OrderRepository(SuperStoreContext context)
        {
            _context = context;
        }

        public Order GetOrderById(int orderId)
        {
            return _context.Orders.Find(orderId);
        }

        public IEnumerable<Order> GetAll()
        {
            return _context.Orders.ToList();
        }

        public IEnumerable<Order> Find(Expression<Func<Order, bool>> expression)
        {
            return _context.Orders.Where(expression);
        }

        public void Add(Order entity)
        {
            _context.Orders.Add(entity);
        }

        public void AddRange(IEnumerable<Order> entities)
        {
            _context.Orders.AddRange(entities);
        }

        public void Remove(Order entity)
        {
            _context.Orders.Remove(entity);
        }

        public void RemoveRange(IEnumerable<Order> entities)
        {
            _context.Orders.RemoveRange(entities);
        }
    }

    public class OrderController : Controller
    {
        private readonly IOrderRepositorye<Order> _orderRepository;

        public OrderController(IOrderRepositorye<Order> orderRepository)
        {
            _orderRepository = orderRepository;
        }

        // GET: Order
        public IActionResult Index()
        {
            var results = _orderRepository.GetAll();
            return View(results);
        }
    }
}

