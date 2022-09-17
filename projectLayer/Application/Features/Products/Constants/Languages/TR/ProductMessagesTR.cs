using eCommerceLayer.Application.Features.Base.Constants.Languages.TR.Base;
using eCommerceLayer.Application.Features.Products.Constants.Standart;

namespace eCommerceLayer.Application.Features.Products.Constants.Languages.TR
{
    public static class ProductMessagesTR
    {
        private class Worker : ProductMessagesStandart.ProductWorker
        {
            internal override string Product()
            {
                return "Ürünler";
            }
            internal override string ProductNameNotNull()
            {
                return $"{ProductMessagesTR.Product} {BaseConstantsTR.Name} {BaseConstantsTR.NotNull}";
            }
            internal override string ProductListed()
            {
                return $"{ProductMessagesTR.Product} {BaseConstantsTR.Listed}";
            }
            internal override string ProductsListed()
            {
                return $"{ProductMessagesTR.Product}ler {BaseConstantsTR.Listed}";
            }
            internal override string ProductAdded()
            {
                return $"{ProductMessagesTR.Product} {BaseConstantsTR.Added}";
            }
            internal override string ProductDeleted()
            {
                return $"{ProductMessagesTR.Product} {BaseConstantsTR.Deleted}";
            }
            internal override string ProductUpdated()
            {
                return $"{ProductMessagesTR.Product} {BaseConstantsTR.Updated}";
            }
            internal override string ProductNotFound()
            {
                return $"{ProductMessagesTR.Product} {BaseConstantsTR.NotFound}";
            }
        }
        readonly static Worker worker = new Worker();
        public static string Product = worker.Product();
        public static string ProductNameNotNull = worker.ProductNameNotNull();
        public static string ProductListed = worker.ProductListed();
        public static string ProductsListed = worker.ProductsListed();
        public static string ProductAdded = worker.ProductAdded();
        public static string ProductDeleted = worker.ProductDeleted();
        public static string ProductUpdated = worker.ProductUpdated();
        public static string ProductNotFound = worker.ProductNotFound();
    }
}