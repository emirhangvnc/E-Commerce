using eCommerceLayer.Application.Features.Products.DTOs;
using eCommerceLayer.Application.Services.Abstract.Base;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Services.Abstract
{
    public interface IProductService : IBaseService<Product,
        ProductAddDTO, ProductDeleteDTO, ProductUpdateDTO>
    {
    }
}