using Core.Application.Requests;
using eCommerceLayer.Application.Features.Concrete.Categories.Commands.AddCategory;
using eCommerceLayer.Application.Features.Concrete.Categories.Commands.DeleteFeature;
using eCommerceLayer.Application.Features.Concrete.Categories.Commands.UpdateCategory;
using eCommerceLayer.Application.Features.Concrete.Categories.Queries.GetAllCategory;
using eCommerceLayer.Application.Features.Concrete.Categories.Queries.GetByIdCategory;
using eCommerceLayer.WebAPI.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceLayer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CategoryAddCommand categoryAddCommand)
        {
            var result = await Mediator.Send(categoryAddCommand);
            return Created("", result);
        }
        [HttpPost]
        public async Task<IActionResult> Delete([FromBody] CategoryDeleteCommand categoryDeleteCommand)
        {
            var result = await Mediator.Send(categoryDeleteCommand);
            return Created("", result);
        }
        [HttpPost]
        public async Task<IActionResult> Update([FromBody] CategoryUpdateCommand categoryUpdateCommand)
        {
            var result = await Mediator.Send(categoryUpdateCommand);
            return Created("", result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListCategoryQuery getListCategoryQuery = new() { PageRequest = pageRequest };
            var result = await Mediator.Send(getListCategoryQuery);
            if(!result.Success)
                return BadRequest(result.Message);
            return Ok(result);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdCategoryQuery getByIdCategoriesQuery)
        {
            var result = await Mediator.Send(getByIdCategoriesQuery);
            if(!result.Success)
                return BadRequest(result.Message);
            return Ok(result);
        }
    }
}