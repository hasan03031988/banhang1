using BanHang.Data.Infrastructure;
using BanHang.Model.Models;

namespace BanHang.Data.Repositories
{
    public interface IPostCategoryRepository
    { }

    public class PostCategoryRepository : RepositoryBase<PostCategory>, IPostCategoryRepository
    {
        public PostCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        { }
    }
}