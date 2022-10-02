using eCommerceLayer.Application.Features.Base.Constants.Standart.Base;

namespace eCommerceLayer.Application.Features.Brands.Constants.Standart
{
    internal static class BrandMessagesStandart
    {
        internal class BrandWorker
        {
            internal virtual string Brand()
            {
                return $"Brand";
            }
            internal virtual string BrandNameNotNull()
            {
                return $"{BrandMessagesStandart.Brand} {BaseConstantsStandart.Name} {BaseConstantsStandart.NotNull}";
            }
            internal virtual string BrandsListed()
            {
                return $"{BrandMessagesStandart.Brand}s {BaseConstantsStandart.Listed}";
            }
            internal virtual string BrandListed()
            {
                return $"{BrandMessagesStandart.Brand} {BaseConstantsStandart.Listed}";
            }
            internal virtual string BrandAdded()
            {
                return $"{BrandMessagesStandart.Brand} {BaseConstantsStandart.Added}";
            }
            internal virtual string BrandDeleted()
            {
                return $"{BrandMessagesStandart.Brand} {BaseConstantsStandart.Deleted}";
            }
            internal virtual string BrandUpdated()
            {
                return $"{BrandMessagesStandart.Brand} {BaseConstantsStandart.Updated}";
            }
            internal virtual string BrandNotFound()
            {
                return $"{BrandMessagesStandart.Brand} {BaseConstantsStandart.NotFound}";
            }
            internal virtual string BrandNameExists()
            {
                return $"{BrandMessagesStandart.Brand} {BaseConstantsStandart.Name} {BaseConstantsStandart.Exists}";
            }
        }
        readonly static BrandWorker worker = new BrandWorker();
        internal static string Brand = worker.Brand();
        internal static string BrandNameNotNull = worker.BrandNameNotNull();
        internal static string BrandListed = worker.BrandListed();
        internal static string BrandsListed = worker.BrandsListed();
        internal static string BrandAdded = worker.BrandAdded();
        internal static string BrandDeleted = worker.BrandDeleted();
        internal static string BrandUpdated = worker.BrandUpdated();
        internal static string BrandNotFound = worker.BrandNotFound();
        internal static string BrandNameExists = worker.BrandNameExists();
    }
}