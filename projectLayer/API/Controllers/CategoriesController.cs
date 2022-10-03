using Microsoft.AspNetCore.Mvc;
using eCommerceLayer.Application.Features.Categories.DTOs;
using Core.Application.Requests;
using eCommerceLayer.Application.Features.Categories.Abstract;

namespace eCommerceLayer.WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CategoryAddDTO addCategoryCommand)
        {
            var result = await _categoryService.Add(addCategoryCommand);
            if (!result.Success)
                return BadRequest(result.Message);
            return Ok(result.Message);
        }

        [HttpPost]
        public async Task<IActionResult> Delete([FromBody] CategoryDeleteDTO deleteCategoryCommand)
        {
            var result = await _categoryService.Delete(deleteCategoryCommand);
            if (!result.Success)
                return BadRequest(result.Message);
            return Ok(result.Message);
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromBody] CategoryUpdateDTO categoryUpdateCommand)
        {
            var result = await _categoryService.Update(categoryUpdateCommand);
            if (!result.Success)
                return BadRequest(result.Message);
            return Ok(result.Message);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
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