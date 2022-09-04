using Core.Persistence.Repositories;

namespace projectLayer.Domain.Entities
{
    public class Category : Entity
    {
        public string CategoryName { get; set; }

        public Category(int id, string categoryName) : base(id)
        {
            CategoryName = categoryName;
        }
    }
}