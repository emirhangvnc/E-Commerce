using Core.Application.Requests;
using eCommerceLayer.Application.Features.Concrete.Cities.Commands.AddCity;
using eCommerceLayer.Application.Features.Concrete.Cities.Commands.DeleteCity;
using eCommerceLayer.Application.Features.Concrete.Cities.Commands.UpdateCity;
using eCommerceLayer.Application.Features.Concrete.Cities.Queries.GetAllCity;
using eCommerceLayer.Application.Features.Concrete.Cities.Queries.GetByIdCity;
using eCommerceLayer.WebAPI.Controllers;

using Microsoft.AspNetCore.Mvc;

namespace eCommerceLayer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CityAddCommand cityAddCommand)
        {
            var result = await Mediator.Send(cityAddCommand);
            return Created("", result);
        }

        [HttpPost]
        public async Task<IActionResult> Delete([FromBody] CityDeleteCommand cityDeleteCommand)
        {
            var result = await Mediator.Send(cityDeleteCommand);
            return Created("", result);
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromBody] CityUpdateCommand cityUpdateCommand)
        {
            var result = await Mediator.Send(cityUpdateCommand);
            return Created("", result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListCityQuery getListCityQuery = new() { PageRequest = pageRequest };
            var result = await Mediator.Send(getListCityQuery);
            if (!result.Success)
                return BadRequest(result.Message);
            return Ok(result);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdCityQuery getByIdCityQuery)
        {
            var result = await Mediator.Send(getByIdCityQuery);
            if (!result.Success)
                return BadRequest(result.Message);
            return Ok(result);
        }
    }
}