using eCommerceLayer.Application.Features.Base.Rules;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.Products.Rules
{
    public interface IProductBusinessRules:IIdNumberExistsService<Product>
    {
    }
}