using projectLayer.Application.Features.Brands.DTOs;
using projectLayer.Application.Services.Abstract.Base;
using projectLayer.Domain.Entities;

namespace projectLayer.Application.Services.Abstract
{
    public interface IBrandService : IBaseService<Brand,
        BrandAddDTO, BrandDeleteDTO, BrandUpdateDTO>
    {
    }
}