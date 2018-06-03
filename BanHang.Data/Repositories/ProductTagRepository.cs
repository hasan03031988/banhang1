using BanHang.Data.Infrastructure;
using BanHang.Model.Models;

namespace BanHang.Data.Repositories
{
    public interface IProductTagRepository
    { }

    public class ProductTagRepository : RepositoryBase<ProductTag>, IProductTagRepository
    {
        public ProductTagRepository(IDbFactory dbFactory) : base(dbFactory)
        { }
    }
}