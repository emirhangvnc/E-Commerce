using eCommerceLayer.Application.Features.Base.Constants.Standart.Base;

namespace eCommerceLayer.Application.Features.Concrete.BrandImages.Constants.Standart
{
    internal static class BrandImageMessagesStandart
    {
        internal class BrandImageWorker
        {
            internal virtual string BrandImage()
            {
                return $"Brand Image";
            }
            internal virtual string BrandImageAdded()
            {
                return $"{BrandImageMessagesStandart.BrandImage} {BaseConstantsStandart.Added}";
            }
            internal virtual string BrandImageDeleted()
            {
                return $"{BrandImageMessagesStandart.BrandImage} {BaseConstantsStandart.Deleted}";
            }
            internal virtual string BrandImageUpdated()
            {
                return $"{BrandImageMessagesStandart.BrandImage} {BaseConstantsStandart.Updated}";
            }
            internal virtual string BrandImageNotFound()
            {
                return $"{BrandImageMessagesStandart.BrandImage} {BaseConstantsStandart.NotFound}";
            }
        }
        readonly static BrandImageWorker worker = new BrandImageWorker();
        internal static string BrandImage = worker.BrandImage();
        internal static string BrandImageAdded = worker.BrandImageAdded();
        internal static string BrandImageDeleted = worker.BrandImageDeleted();
        internal static string BrandImageUpdated = worker.BrandImageUpdated();
        internal static string BrandImageNotFound = worker.BrandImageNotFound();
    }
}