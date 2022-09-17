using Core.Application.Requests;
using Microsoft.AspNetCore.Mvc;
using eCommerceLayer.Application.Features.Brands.Commands.CreateBrand;
using eCommerceLayer.Application.Features.Brands.DTOs;
using eCommerceLayer.Application.Features.Brands.Models;
using eCommerceLayer.Application.Features.Brands.Queries.GetByIdBrand;
using eCommerceLayer.Application.Features.Brands.Queries.GetListBrand;

namespace eCommerceLayer.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateBrandCommand createBrandCommand)
        {
            BrandAddDTO result = await Mediator.Send(createBrandCommand);
            return Created("", result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListBrandQuery getListBrandQuery = new() { PageRequest = pageRequest };
            BrandListModel result = await Mediator.Send(getListBrandQuery);
            return Ok(result);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdBrandQuery getByIdIdBrandQuery)
        {
            BrandGetByIdDto brandGetByIdDto = await Mediator.Send(getByIdIdBrandQuery);
            return Ok(brandGetByIdDto);
        }
    }
}