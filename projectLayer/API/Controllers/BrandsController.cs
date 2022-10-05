using Core.Application.Requests;
using Microsoft.AspNetCore.Mvc;
using eCommerceLayer.Application.Features.Concrete.Brands.DTOs;
using eCommerceLayer.Application.Features.Concrete.Brands.Abstract;

namespace eCommerceLayer.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : BaseController
    {
        IBrandService _brandService;
        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] BrandAddDTO addBrandCommand)
        {
            var result = await _brandService.Add(addBrandCommand);
            if (!result.Success)
                return BadRequest(result.Message);
            return Ok(result.Message);
        }

        [HttpPost]
        public async Task<IActionResult> Delete([FromBody] BrandDeleteDTO deleteBrandCommand)
        {
            var result = await _brandService.Delete(deleteBrandCommand);
            if (!result.Success)
                return BadRequest(result.Message);
            return Ok(result.Message);
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromBody] BrandUpdateDTO updateBrandCommand)
        {
            var result = await _brandService.Update(updateBrandCommand);
            if (!result.Success)
                return BadRequest(result.Message);

            return Ok(result.Message);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            //var result = await _categoryService.(pageRequest);
            //var result = await _categoryService.(pageRequest);
            return Ok();
        }

        //[HttpGet("{Id}")]
        //public async Task<IActionResult> GetById([FromRoute] GetByIdBrandQuery getByIdIdBrandQuery)
        //{
        //    BrandGetByIdDto brandGetByIdDto = await Mediator.Send(getByIdIdBrandQuery);
        //    return Ok(brandGetByIdDto);
        //}
    }
}