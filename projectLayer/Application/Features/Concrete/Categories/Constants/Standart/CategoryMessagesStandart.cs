using eCommerceLayer.Application.Features.Base.Constants.Standart.Base;

namespace eCommerceLayer.Application.Features.Concrete.Categories.Constants.Standart
{
    internal static class CategoryMessagesStandart
    {
        internal class CategoryWorker
        {
            internal virtual string Category()
            {
                return $"Category";
            }
            internal virtual string CategoryNameNotNull()
            {
                return $"{CategoryMessagesStandart.Category} {BaseConstantsStandart.Name} {BaseConstantsStandart.NotNull}";
            }
            internal virtual string CategoriesListed()
            {
                return $"Cities {BaseConstantsStandart.Listed}";
            }
            internal virtual string CategoryListed()
            {
                return $"{CategoryMessagesStandart.Category} {BaseConstantsStandart.Listed}";
            }
            internal virtual string CategoryAdded()
            {
                return $"{CategoryMessagesStandart.Category} {BaseConstantsStandart.Added}";
            }
            internal virtual string CategoryDeleted()
            {
                return $"{CategoryMessagesStandart.Category} {BaseConstantsStandart.Deleted}";
            }
            internal virtual string CategoryUpdated()
            {
                return $"{CategoryMessagesStandart.Category} {BaseConstantsStandart.Updated}";
            }
            internal virtual string CategoryNotFound()
            {
                return $"{CategoryMessagesStandart.Category} {BaseConstantsStandart.NotFound}";
            }
            internal virtual string CategoryNameExists()
            {
                return $"{CategoryMessagesStandart.Category} {BaseConstantsStandart.Name} {BaseConstantsStandart.Exists}";
            }
        }
        readonly static CategoryWorker worker = new CategoryWorker();
        internal static string Category = worker.Category();
        internal static string CategoryNameNotNull = worker.CategoryNameNotNull();
        internal static string CategoryListed = worker.CategoryListed();
        internal static string CategoriesListed = worker.CategoriesListed();
        internal static string CategoryAdded = worker.CategoryAdded();
        internal static string CategoryDeleted = worker.CategoryDeleted();
        internal static string CategoryUpdated = worker.CategoryUpdated();
        internal static string CategoryNotFound = worker.CategoryNotFound();
        internal static string CategoryNameExists = worker.CategoryNameExists();
    }
}