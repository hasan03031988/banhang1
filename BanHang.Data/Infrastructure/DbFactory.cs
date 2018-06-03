using System;
using BanHang.Data;

namespace BanHang.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private BanHangDbContext dbcontext;

        public BanHangDbContext Init()
        {
            return dbcontext ?? (dbcontext = new BanHangDbContext());
        }

        protected override void DisposeCore()
        {
            //base.DisposeCore();
            if (dbcontext != null)
                dbcontext.Dispose();
        }
    }
}