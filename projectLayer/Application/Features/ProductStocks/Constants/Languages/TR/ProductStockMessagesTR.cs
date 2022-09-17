using eCommerceLayer.Application.Features.Base.Constants.Languages.TR.Base;
using eCommerceLayer.Application.Features.Products.Constants.Standart;
using eCommerceLayer.Application.Features.ProductStocks.Constants.Standart;

namespace eCommerceLayer.Application.Features.ProductStocks.Constants.Languages.TR
{
    public static class ProductStockMessagesTR
    {
        private class Worker : ProductStockMessagesStandart.ProductStockWorker
        {
            internal override string ProductStock()
            {
                return $"Ürün Stok";
            }
            internal override string ProductIdNotNull()
            {
                return $"{ProductStockMessagesTR.ProductStock} {BaseConstantsTR.ID} {BaseConstantsTR.NotNull}";
            }
            internal override string ProductStockNotNull()
            {
                return $"{ProductStockMessagesTR.ProductStock} {BaseConstantsTR.Stock} {BaseConstantsTR.NotNull}";
            }
            internal override string ProductStocksListed()
            {
                return $"{ProductStockMessagesTR.ProductStock} {BaseConstantsTR.Listed}";
            }
            internal override string ProductStockListed()
            {
                return $"{ProductStockMessagesTR.ProductStock} {BaseConstantsTR.Listed}";
            }
            internal override string ProductStockUpdated()
            {
                return $"{ProductStockMessagesTR.ProductStock} {BaseConstantsTR.Updated}";
            }
            internal override string ProductStockAdded()
            {
                return $"{ProductStockMessagesTR.ProductStock} {BaseConstantsTR.Added}";
            }
            internal override string ProductStockDeleted()
            {
                return $"{ProductStockMessagesTR.ProductStock} {BaseConstantsTR.Deleted}";
            }
            internal override string ProductStocktNotFound()
            {
                return $"{ProductStockMessagesTR.ProductStock} {BaseConstantsTR.NotFound}";
            }
        }
        readonly static Worker worker = new Worker();
        internal static string ProductStock = worker.ProductStock();
        internal static string ProductStockListed = worker.ProductStockListed();
        internal static string ProductStocksListed = worker.ProductStocksListed();
        internal static string ProductStockDeleted = worker.ProductStockDeleted();
        internal static string ProductStockUpdated = worker.ProductStockUpdated();
        internal static string ProductStockAdded = worker.ProductStockAdded();
        internal static string ProductStocktNotFound = worker.ProductStocktNotFound();
    }
}