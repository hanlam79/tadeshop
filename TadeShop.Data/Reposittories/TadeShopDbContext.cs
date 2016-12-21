using System;

namespace TadeShop.Data.Infrastructure
{
    public class TadeShopDbContext
    {
        public object ProductCategories { get; internal set; }

        internal object Set<T>()
        {
            throw new NotImplementedException();
        }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }

        internal void Dispose()
        {
            throw new NotImplementedException();
        }

        internal object Entry<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }
    }
}