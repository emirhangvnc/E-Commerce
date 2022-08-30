using coreLayer.Permanency.Repositories;

namespace projectLayer.Domain.Entities
{
    public class BrandImage : Entity
    {
        public int BrandId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public BrandImage(int brandId, string fileName, string filePath, DateTime createdDate, DateTime updatedDate)
        {
            BrandId = brandId;
            FileName = fileName;
            FilePath = filePath;
            CreatedDate = createdDate;
            UpdatedDate = updatedDate;
        }

        public BrandImage(int id, int brandId, string fileName, string filePath, DateTime createdDate, DateTime updatedDate) : this(brandId, fileName, filePath, createdDate, updatedDate)
        {
            Id = id;
        }
    }
}