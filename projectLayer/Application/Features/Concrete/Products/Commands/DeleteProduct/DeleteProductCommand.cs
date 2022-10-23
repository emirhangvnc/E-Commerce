using AutoMapper;
using eCommerceLayer.Domain.Entities;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Base.Commands;
using eCommerceLayer.Persistence.Concrete.Contexts;
using static Core.Application.Pipelines.Validation.ValidationTool;
using eCommerceLayer.Application.Features.Concrete.Products.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Concrete.Products.Rules;
using eCommerceLayer.Application.Features.Concrete.Products.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.ProductStocks.Commands.DeleteProduct
{
    public class DeleteProductCommand : ManagerBase, IDeleteProductService
    {
        IProductBusinessRules _productBusinessRules;
        public DeleteProductCommand(BaseDbContext context, IMapper mapper, IProductBusinessRules productBusinessRules) : base(mapper, context)
        {
            _productBusinessRules = productBusinessRules;
        }

        [ValidationAspect(typeof(DeleteProductDTOValidator))]
        public async Task<IResult> Delete(ProductDeleteDTO deletedDto)
        {
            var result = _productBusinessRules.IsIDExists(deletedDto.Id);
            if (result.Result.Data == null)
                return new ErrorResult(ProductMessagesTR.ProductNotFound);

            var product = Mapper.Map<Product>(result);
            await Task.Run(() => DbContext.Products.Remove(product));
            await DbContext.SaveChangesAsync();
            return new SuccessResult(ProductMessagesTR.ProductDeleted);
        }
    }
}