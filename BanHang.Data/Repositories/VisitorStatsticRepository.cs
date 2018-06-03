﻿using BanHang.Data.Infrastructure;
using BanHang.Model.Models;

namespace BanHang.Data.Repositories
{
    public interface IVisitorStatsticRepository
    { }

    public class VisitorStatsticRepository : RepositoryBase<VisitorStatistic>, IVisitorStatsticRepository
    {
        public VisitorStatsticRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}