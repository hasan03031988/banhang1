using BanHang.Data.Infrastructure;
using BanHang.Model.Models;

namespace BanHang.Data.Repositories
{
    public interface IMenuGroupRepository
    { }

    public class MenuGroupRepository : RepositoryBase<MenuGroup>, IMenuGroupRepository
    {
        public MenuGroupRepository(IDbFactory dbFactory) : base(dbFactory)
        { }
    }
}