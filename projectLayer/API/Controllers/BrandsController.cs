using Core.Application.Requests;
using Microsoft.AspNetCore.Mvc;
using projectLayer.Application.Features.Brands.Commands.CreateBrand;
using projectLayer.Application.Features.Brands.DTOs;
using projectLayer.Application.Features.Brands.Models;
using projectLayer.Application.Features.Brands.Queries.GetByIdBrand;
using projectLayer.Application.Features.Brands.Queries.GetListBrand;

namespace projectLayer.WebAPI.Controllers
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