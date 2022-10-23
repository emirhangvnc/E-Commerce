using Core.Persistence.Repositories;
using Microsoft.AspNetCore.Http;

namespace eCommerceLayer.Application.Features.Concrete.BrandImages.DTOs
{
    public class BrandImageUpdateDTO:IDTO
    {
        public int ID { get; set; }
        public int BrandId { get; set; }
        public IFormFile File { get; set; }
    }
}