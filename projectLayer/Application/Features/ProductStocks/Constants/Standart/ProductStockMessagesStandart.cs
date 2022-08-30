using projectLayer.Application.Features.Base.Constants.Standart.Base;
using projectLayer.Application.Features.Products.Constants.Standart;

namespace projectLayer.Application.Features.ProductStocks.Constants.Standart
{
    internal static class ProductStockMessagesStandart
    {
        internal class ProductStockWorker
        {
            internal virtual string ProductStock()
            {
                return $"Product Stock";
            }
            internal virtual string ProductIdNotNull()
            {
                return $"{ProductMessagesStandart.Product} {BaseConstantsStandart.ID} {BaseConstantsStandart.NotNull}";
            }
            internal virtual string ProductStockNotNull()
            {
                return $"{ProductMessagesStandart.Product} {BaseConstantsStandart.Stock} {BaseConstantsStandart.NotNull}";
            }
            internal virtual string ProductStocksListed()
            {
                return $"{ProductStockMessagesStandart.ProductStock} {BaseConstantsStandart.Listed}";
            }
            internal virtual string ProductStockListed()
            {
                return $"{ProductStockMessagesStandart.ProductStock} {BaseConstantsStandart.Listed}";
            }
            internal virtual string ProductStockUpdated()
            {
                return $"{ProductStockMessagesStandart.ProductStock} {BaseConstantsStandart.Updated}";
            }
            internal virtual string ProductStockAdded()
            {
                return $"{ProductStockMessagesStandart.ProductStock} {BaseConstantsStandart.Added}";
            }
            internal virtual string ProductStockDeleted()
            {
                return $"{ProductStockMessagesStandart.ProductStock} {BaseConstantsStandart.Deleted}";
            }
            internal virtual string ProductStocktNotFound()
            {
                return $"{ProductStockMessagesStandart.ProductStock} {BaseConstantsStandart.NotFound}";
            }
        }
        readonly static ProductStockWorker worker = new ProductStockWorker();
        internal static string ProductStock = worker.ProductStock();
        internal static string ProductStockListed = worker.ProductStockListed();
        internal static string ProductStocksListed = worker.ProductStocksListed();
        internal static string ProductStockDeleted = worker.ProductStockDeleted();
        internal static string ProductStockUpdated = worker.ProductStockUpdated();
        internal static string ProductStockAdded = worker.ProductStockAdded();
        internal static string ProductStocktNotFound = worker.ProductStocktNotFound();
    }
}