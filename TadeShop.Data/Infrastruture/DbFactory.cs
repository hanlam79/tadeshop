namespace TadeShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private TadeShopDbContext dbContext;

        public TadeShopDbContext Init()
        {
            return dbContext ?? (dbContext = new TadeShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}