using EcommerceCheckoutAPI.Models;
using EcommerceCheckoutAPI.Repositories;
using Microsoft.IdentityModel.Protocols;

namespace EcommerceCheckoutAPI.Services
{
    public class CatalogService : ICatalogService
    {
        private readonly ICatalogRepository _catalogRepository;
        public CatalogService(ICatalogRepository catalogRepository)
        {
            _catalogRepository = catalogRepository;
        }
        public double GetCheckoutPrice(List<string> watches)
        {
            var totalPrice = 0.00;

            List<WatchCatalogue> dbWatchCatalogues = new List<WatchCatalogue>();
            dbWatchCatalogues = _catalogRepository.GetCatalogRepository();

            // Pair the requested watches with Qty
            Dictionary<string, int> numberOfWatches = new Dictionary<string, int>();

            foreach (var watch in watches)
            {
                if (numberOfWatches.ContainsKey(watch))
                {
                    numberOfWatches[watch]++;
                }
                else
                {
                    numberOfWatches.Add(watch, 1);
                }
            } 

            foreach (var watchWithQty in numberOfWatches)
            {
                var watchName = watchWithQty.Key;
                var QtyAsked = watchWithQty.Value;

                var dbRecord = dbWatchCatalogues.FirstOrDefault(x => x.WatchName == watchName);

                if (dbRecord.Discount != null && (QtyAsked >= dbRecord.Quantity && QtyAsked % dbRecord.Quantity == 0))
                {
                    var noOfTimes = QtyAsked/dbRecord.Quantity;
                    var price =  noOfTimes * dbRecord.Discount;
                    totalPrice += (double)price;
                }
                else if (dbRecord.Discount != null && (QtyAsked >= dbRecord.Quantity && QtyAsked % dbRecord.Quantity != 0))
                {
                    var discountedQty = QtyAsked/dbRecord.Quantity;
                    var nonDiscountedQty = QtyAsked%dbRecord.Quantity;
                    var price = discountedQty * dbRecord.Discount + nonDiscountedQty * dbRecord.UnitPrice;
                    totalPrice += (double)price;
                }
                else
                {
                    var price = dbRecord.UnitPrice * QtyAsked;
                    totalPrice += price;
                }
            }               
            return totalPrice;
        }
    }
}



