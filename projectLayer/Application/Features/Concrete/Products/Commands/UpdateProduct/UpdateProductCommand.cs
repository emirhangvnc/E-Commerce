using AutoMapper;
using Core.Security.Results;
using eCommerceLayer.Application.Features.Base.Commands;
using eCommerceLayer.Application.Features.Concrete.Products.Commands.UpdateProduct;
using eCommerceLayer.Application.Features.Concrete.Products.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Concrete.Products.DTOs;
using eCommerceLayer.Application.Features.Concrete.Products.Rules;
using eCommerceLayer.Domain.Entities;
using eCommerceLayer.Persistence.Concrete.Contexts;
using static Core.Application.Pipelines.Validation.ValidationTool;

namespace eCommerceLayer.Application.Features.Concrete.ProductStocks.Commands.UpdateProduct
{
    public class UpdateProductCommand : ManagerBase, IUpdateProductService
    {
        IProductBusinessRules _productBusinessRules;
        public UpdateProductCommand(BaseDbContext context, IMapper mapper, IProductBusinessRules productBusinessRules) : base(mapper, context)
        {
            _productBusinessRules = productBusinessRules;
        }

        [ValidationAspect(typeof(UpdateProductDTOValidator))]
        public async Task<IResult> Update(ProductUpdateDTO updateDto)
        {
            var result = _productBusinessRules.IsIDExists(updateDto.Id);
            if (result.Result.Data == null)
                return new ErrorResult(ProductMessagesTR.ProductNotFound);

            var product = Mapper.Map<Product>(result);
            product.UpdatedDate = DateTime.Now;
            await Task.Run(() => DbContext.Products.Update(product));
            await DbContext.SaveChangesAsync();
            return new SuccessResult(ProductMessagesTR.ProductUpdated);
        }
    }
}