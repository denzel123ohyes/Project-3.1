

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
    public class CustomerRepository : ICustomerRepositorye<Customer>
    {
        private readonly SuperStoreContext _context;

        public CustomerRepository(SuperStoreContext context)
        {
            _context = context;
        }

        public Customer GetOrderById(int customerId)
        {
            return _context.Customers.Find(customerId);
        }

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        public IEnumerable<Customer> Find(Expression<Func<Customer, bool>> expression)
        {
            return _context.Customers.Where(expression);
        }

        public void Add(Customer entity)
        {
            _context.Customers.Add(entity);
        }

        public void AddRange(IEnumerable<Customer> entities)
        {
            _context.Customers.AddRange(entities);
        }

        public void Remove(Customer entity)
        {
            _context.Customers.Remove(entity);
        }

        public void RemoveRange(IEnumerable<Customer> entities)
        {
            _context.Customers.RemoveRange(entities);
        }
    }

    public class CustomerController : Controller
    {
        private readonly ICustomerRepositorye<Customer> _customerRepository;

        public CustomerController(ICustomerRepositorye<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        // GET: Customer
        public IActionResult Index()
        {
            var results = _customerRepository.GetAll();
            return View(results);
        }
    }
}
