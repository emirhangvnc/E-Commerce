using eCommerceLayer.Domain.Entities;
using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Base.Commands;
using eCommerceLayer.Persistence.Concrete.Contexts;
using Microsoft.EntityFrameworkCore;
using eCommerceLayer.Application.Features.Concrete.Products.Constants.Languages.TR;

namespace eCommerceLayer.Application.Features.Concrete.Products.Rules
{
    public class ProductBusinessRules : ManagerBase, IProductBusinessRules
    {
        public ProductBusinessRules(IMapper mapper, BaseDbContext context) : base(mapper, context)
        {
        }

        public async Task<IDataResult<Product>> IsIDExists(int id)
        {
            var result = await DbContext.Products.SingleOrDefaultAsync(p => p.Id == id);
            if (result == null)
                return new ErrorDataResult<Product>(ProductMessagesTR.ProductNotFound);  

            return new SuccessDataResult<Product>(result);
        }
    }
}