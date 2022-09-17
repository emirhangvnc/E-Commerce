using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities.Base;

namespace eCommerceLayer.Domain.Entities
{
    public class ProductImage : BaseEntity, IEntity
    {
        public int ProductId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ProductImage(int id,int productId, string fileName, string filePath, DateTime createdDate, DateTime updatedDate):base(id)
        {
            ProductId = productId;
            FileName = fileName;
            FilePath = filePath;
            CreatedDate = createdDate;
            UpdatedDate = updatedDate;
        }
    }
}