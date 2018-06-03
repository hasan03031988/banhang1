using BanHang.Data.Infrastructure;
using BanHang.Model.Models;

namespace BanHang.Data.Repositories
{
    public interface IOrderRepository
    { }

    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}