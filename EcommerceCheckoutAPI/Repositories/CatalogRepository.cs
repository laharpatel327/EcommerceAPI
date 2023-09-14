using EcommerceCheckoutAPI.Models;

namespace EcommerceCheckoutAPI.Repositories
{
    public class CatalogRepository : ICatalogRepository
    {
        private readonly CatalogContext _catalogContext;

        public CatalogRepository(CatalogContext catalogContext)
        {
            _catalogContext = catalogContext;
        }

        public List<WatchCatalogue> GetCatalogRepository()
        {
            var watchCatalogues = _catalogContext.WatchCatalogues.ToList();
            return watchCatalogues;
        }
    }
}
