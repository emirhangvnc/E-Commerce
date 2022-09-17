using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities.Base;

namespace eCommerceLayer.Domain.Entities
{
    public class BrandImage : BaseEntity, IEntity
    {
        public int BrandId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public BrandImage(int id, int brandId, string fileName, string filePath, DateTime createdDate, DateTime updatedDate) : base(id)
        {
            BrandId = brandId;
            FileName = fileName;
            FilePath = filePath;
            CreatedDate = createdDate;
            UpdatedDate = updatedDate;
        }
    }
}