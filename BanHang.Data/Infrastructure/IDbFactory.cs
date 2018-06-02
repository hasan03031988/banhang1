using System;

namespace BanHang.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        BanHangDbContext Init();
    }
}