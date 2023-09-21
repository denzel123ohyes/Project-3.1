using Models;

namespace EcoPower_Logistics.Repository
{
    public interface IServiceRepository : IGenericRepository<Order>
    {
        Order GetMostRecentService();
    }

}
