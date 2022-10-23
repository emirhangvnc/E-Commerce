using eCommerceLayer.Application.Features.Base.Constants.Languages.TR.Base;
using eCommerceLayer.Application.Features.Concrete.BrandImages.Constants.Standart;

namespace eCommerceLayer.Application.Features.Concrete.BrandImages.Constants.Languages.TR
{
    public static class BrandImageMessagesTR
    {
        private class Worker : BrandImageMessagesStandart.BrandImageWorker
        {
            internal override string BrandImage()
            {
                return "Marka Resmi";
            }
            internal override string BrandImageAdded()
            {
                return $"{BrandImageMessagesTR.BrandImage} {BaseConstantsTR.Added}";
            }
            internal override string BrandImageDeleted()
            {
                return $"{BrandImageMessagesTR.BrandImage} {BaseConstantsTR.Deleted}";
            }
            internal override string BrandImageUpdated()
            {
                return $"{BrandImageMessagesTR.BrandImage} {BaseConstantsTR.Updated}";
            }
            internal override string BrandImageNotFound()
            {
                return $"{BrandImageMessagesTR.BrandImage} {BaseConstantsTR.NotFound}";
            }
        }
        readonly static Worker worker = new Worker();
        public static string BrandImage = worker.BrandImage();
        public static string BrandImageAdded = worker.BrandImageAdded();
        public static string BrandImageDeleted = worker.BrandImageDeleted();
        public static string BrandImageUpdated = worker.BrandImageUpdated();
        public static string BrandImageNotFound = worker.BrandImageNotFound();
    }
}