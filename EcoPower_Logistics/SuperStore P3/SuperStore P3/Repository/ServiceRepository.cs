using Data;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class ServiceRepository : GenericRepository<Order>, IServiceRepository
    {
        public ServiceRepository(SuperStoreContext context) : base(context)
        {
        }

        public Order GetMostRecentService()
        {
            return _context.Orders.OrderByDescending(service => service.OrderDate).FirstOrDefault();
        }
    }

}
