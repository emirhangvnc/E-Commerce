using Core.Persistence.Repositories;

namespace projectLayer.Domain.Entities
{
    public class ProductImage : Entity
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