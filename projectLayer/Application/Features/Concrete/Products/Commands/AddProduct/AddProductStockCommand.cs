using AutoMapper;
using eCommerceLayer.Domain.Entities;
using eCommerceLayer.Persistence.Concrete.Contexts;
using static Core.Application.Pipelines.Validation.ValidationTool;
using Core.Security.Results;
using eCommerceLayer.Application.Features.Base.Commands;
using eCommerceLayer.Application.Features.Concrete.Products.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Concrete.Products.Commands.AddProduct;
using eCommerceLayer.Application.Features.Concrete.Products.DTOs;
using eCommerceLayer.Application.Features.Concrete.Products.Rules;

namespace eCommerceLayer.Application.Features.Concrete.ProductStocks.Commands.AddProduct
{
    public class AddProductCommand:ManagerBase, IAddProductService
    {
        IProductBusinessRules _productBusinessRules;
        public AddProductCommand(IMapper mapper, BaseDbContext context, IProductBusinessRules productBusinessRules) : base(mapper, context)
        {
            _productBusinessRules = productBusinessRules;
        }

        [ValidationAspect(typeof(AddProductDTOValidator))]
        public async Task<IResult> Add(ProductAddDTO addedDto)
        {
            var product = Mapper.Map<Product>(addedDto);
            product.CreatedDate = DateTime.Now;
            await DbContext.Products.AddAsync(product);
            await DbContext.SaveChangesAsync();
            return new SuccessResult(ProductMessagesTR.ProductAdded);
        }
    }
}