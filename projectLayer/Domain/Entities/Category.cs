using coreLayer.Persistence.Repositories;

namespace projectLayer.Domain.Entities
{
    public class Category : Entity
    {
        public string CategoryName { get; set; }

        public Category(string categoryName)
        {
            CategoryName = categoryName;
        }

        public Category(int id, string categoryName) :this(categoryName)
        {
            Id = id;
        }
    }
}