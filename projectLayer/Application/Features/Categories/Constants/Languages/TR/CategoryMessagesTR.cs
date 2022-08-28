using Application.Features.Categories.Constants.Standart;
using projectLayer.Application.Features.Base.Constants.Languages.TR.Base;

namespace projectLayer.Application.Features.Categories.Constants.Languages.TR
{
    public static class CategoryMessagesTR
    {
        private class Worker : CategoryMessagesStandart.CategoryWorker
        {
            internal override string Category()
            {
                return "Kategori";
            }
            internal override string CategoryNameNotNull()
            {
                return $"{CategoryMessagesTR.Category} {BaseConstantsTR.Name} {BaseConstantsTR.NotNull}";
            }
            internal override string CategoryListed()
            {
                return $"{CategoryMessagesTR.Category} {BaseConstantsTR.Listed}";
            }
            internal override string CategoriesListed()
            {
                return $"{CategoryMessagesTR.Category}ler {BaseConstantsTR.Listed}";
            }
            internal override string CategoryAdded()
            {
                return $"{CategoryMessagesTR.Category} {BaseConstantsTR.Added}";
            }
            internal override string CategoryDeleted()
            {
                return $"{CategoryMessagesTR.Category} {BaseConstantsTR.Deleted}";
            }
            internal override string CategoryUpdated()
            {
                return $"{CategoryMessagesTR.Category} {BaseConstantsTR.Updated}";
            }
            internal override string CategoryNotFound()
            {
                return $"{CategoryMessagesTR.Category} {BaseConstantsTR.NotFound}";
            }
        }
        readonly static Worker worker = new Worker();
        public static string Category = worker.Category();
        public static string CategoryNameNotNull = worker.CategoryNameNotNull();
        public static string CategoryListed = worker.CategoryListed();
        public static string CitiesListed = worker.CategoriesListed();
        public static string CategoryAdded = worker.CategoryAdded();
        public static string CategoryDeleted = worker.CategoryDeleted();
        public static string CategoryUpdated = worker.CategoryUpdated();
        public static string CategoryNotFound = worker.CategoryNotFound();
    }
}