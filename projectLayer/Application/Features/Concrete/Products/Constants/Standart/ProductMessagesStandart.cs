using eCommerceLayer.Application.Features.Base.Constants.Standart.Base;

namespace eCommerceLayer.Application.Features.Concrete.Products.Constants.Standart
{
    internal static class ProductMessagesStandart
    {
        internal class ProductWorker
        {
            internal virtual string Product()
            {
                return $"Product";
            }
            internal virtual string ProductNameNotNull()
            {
                return $"{ProductMessagesStandart.Product} {BaseConstantsStandart.Name} {BaseConstantsStandart.NotNull}";
            }
            internal virtual string ProductsListed()
            {
                return $"Products {BaseConstantsStandart.Listed}";
            }
            internal virtual string ProductListed()
            {
                return $"{ProductMessagesStandart.Product} {BaseConstantsStandart.Listed}";
            }
            internal virtual string ProductAdded()
            {
                return $"{ProductMessagesStandart.Product} {BaseConstantsStandart.Added}";
            }
            internal virtual string ProductDeleted()
            {
                return $"{ProductMessagesStandart.Product} {BaseConstantsStandart.Deleted}";
            }
            internal virtual string ProductUpdated()
            {
                return $"{ProductMessagesStandart.Product} {BaseConstantsStandart.Updated}";
            }
            internal virtual string ProductNotFound()
            {
                return $"{ProductMessagesStandart.Product} {BaseConstantsStandart.NotFound}";
            }
        }
        readonly static ProductWorker worker = new ProductWorker();
        internal static string Product = worker.Product();
        internal static string ProductNameNotNull = worker.ProductNameNotNull();
        internal static string ProductListed = worker.ProductListed();
        internal static string ProductsListed = worker.ProductsListed();
        internal static string ProductAdded = worker.ProductAdded();
        internal static string ProductDeleted = worker.ProductDeleted();
        internal static string ProductUpdated = worker.ProductUpdated();
        internal static string ProductNotFound = worker.ProductNotFound();
    }
}