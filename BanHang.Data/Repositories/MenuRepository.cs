using BanHang.Data.Infrastructure;
using BanHang.Model.Models;

namespace BanHang.Data.Repositories
{
    public interface IMenuRepository
    { }

    public class MenuRepository : RepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(IDbFactory dbFactory) : base(dbFactory)
        { }
    }
}