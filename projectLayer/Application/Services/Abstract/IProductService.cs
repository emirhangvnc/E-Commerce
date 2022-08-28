using projectLayer.Application.Features.Products.DTOs;
using projectLayer.Application.Services.Abstract.Base;
using projectLayer.Domain.Entities;

namespace projectLayer.Application.Services.Abstract
{
    public interface IProductService : IBaseService<Product,
        ProductAddDTO, ProductDeleteDTO, ProductUpdateDTO>
    {
    }
}