using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities.Base;

namespace eCommerceLayer.Domain.Entities
{
    public class Category : BaseEntity, IEntity
    {
        public string CategoryName { get; set; }

        public Category(int id, string categoryName) : base(id)
        {
            CategoryName = categoryName;
        }
    }
}