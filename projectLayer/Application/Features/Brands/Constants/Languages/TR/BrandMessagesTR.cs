using eCommerceLayer.Application.Features.Brands.Constants.Standart;
using eCommerceLayer.Application.Features.Base.Constants.Languages.TR.Base;

namespace eCommerceLayer.Application.Features.Brands.Constants.Languages.TR
{
    public static class BrandMessagesTR
    {
        private class Worker : BrandMessagesStandart.BrandWorker
        {
            internal override string Brand()
            {
                return "Marka";
            }
            internal override string BrandNameNotNull()
            {
                return $"{BrandMessagesTR.Brand} {BaseConstantsTR.Name} {BaseConstantsTR.NotNull}";
            }
            internal override string BrandListed()
            {
                return $"{BrandMessagesTR.Brand} {BaseConstantsTR.Listed}";
            }
            internal override string BrandsListed()
            {
                return $"{BrandMessagesTR.Brand}lar {BaseConstantsTR.Listed}";
            }
            internal override string BrandAdded()
            {
                return $"{BrandMessagesTR.Brand} {BaseConstantsTR.Added}";
            }
            internal override string BrandDeleted()
            {
                return $"{BrandMessagesTR.Brand} {BaseConstantsTR.Deleted}";
            }
            internal override string BrandUpdated()
            {
                return $"{BrandMessagesTR.Brand} {BaseConstantsTR.Updated}";
            }
            internal override string BrandNotFound()
            {
                return $"{BrandMessagesTR.Brand} {BaseConstantsTR.NotFound}";
            }
        }
        readonly static Worker worker = new Worker();
        public static string Brand = worker.Brand();
        public static string BrandNameNotNull = worker.BrandNameNotNull();
        public static string BrandListed = worker.BrandListed();
        public static string BrandsListed = worker.BrandsListed();
        public static string BrandAdded = worker.BrandAdded();
        public static string BrandDeleted = worker.BrandDeleted();
        public static string BrandUpdated = worker.BrandUpdated();
        public static string BrandNotFound = worker.BrandNotFound();
    }
}