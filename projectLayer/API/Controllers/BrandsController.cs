using Core.Application.Requests;
using eCommerceLayer.Application.Features.Concrete.Brands.Commands.AddBrand;
using eCommerceLayer.Application.Features.Concrete.Brands.Commands.DeleteBrand;
using eCommerceLayer.Application.Features.Concrete.Brands.Commands.UpdateBrand;
using eCommerceLayer.Application.Features.Concrete.Brands.Queries.GetAllBrand;
using eCommerceLayer.Application.Features.Concrete.Brands.Queries.GetByIdBrand;
using eCommerceLayer.WebAPI.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceLayer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] BrandAddCommand brandAddCommand)
        {
            var result = await Mediator.Send(brandAddCommand);
            return Created("", result);
        }

        [HttpPost]
        public async Task<IActionResult> Delete([FromBody] BrandDeleteCommand brandDeleteCommand)
        {
            var result = await Mediator.Send(brandDeleteCommand);
            return Created("", result);
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromBody] BrandUpdateCommand brandUpdateCommand)
        {
            var result = await Mediator.Send(brandUpdateCommand);
            return Created("", result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListBrandQuery getListBrandQuery = new() { PageRequest = pageRequest };
            var result = await Mediator.Send(getListBrandQuery);
            if (!result.Success)
                return BadRequest(result.Message);
            return Ok(result);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdBrandQuery getByIdBrandsQuery)
        {
            var result = await Mediator.Send(getByIdBrandsQuery);
            if (!result.Success)
                return BadRequest(result.Message);
            return Ok(result);
        }
    }
}