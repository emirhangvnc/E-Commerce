using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities.Base;

namespace eCommerceLayer.Domain.Entities
{
    public class ProductImage : BaseEntity, IEntity
    {
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public string? FileName { get; set; }
        public string? FilePath { get; set; }
    }
}