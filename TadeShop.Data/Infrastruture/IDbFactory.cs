using System;

namespace TadeShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        TadeShopDbContext Init();
    }
}