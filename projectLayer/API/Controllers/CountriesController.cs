using Core.Application.Requests;
using eCommerceLayer.Application.Features.Concrete.Countries.Commands.AddCountry;
using eCommerceLayer.Application.Features.Concrete.Countries.Commands.DeleteCountry;
using eCommerceLayer.Application.Features.Concrete.Countries.Commands.UpdateCountry;
using eCommerceLayer.Application.Features.Concrete.Countries.Queries.GetAllCountry;
using eCommerceLayer.Application.Features.Concrete.Countries.Queries.GetByIdCountry;
using eCommerceLayer.WebAPI.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceLayer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CountryAddCommand countryAddCommand)
        {
            var result = await Mediator.Send(countryAddCommand);
            return Created("", result);
        }

        [HttpPost]
        public async Task<IActionResult> Delete([FromBody] CountryDeleteCommand countryDeleteCommand)
        {
            var result = await Mediator.Send(countryDeleteCommand);
            return Created("", result);
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromBody] CountryUpdateCommand countryUpdateCommand)
        {
            var result = await Mediator.Send(countryUpdateCommand);
            return Created("", result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListCountryQuery getListCountryQuery = new() { PageRequest = pageRequest };
            var result = await Mediator.Send(getListCountryQuery);
            if (!result.Success)
                return BadRequest(result.Message);
            return Ok(result);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdCountryQuery getByIdCountryQuery)
        {
            var result = await Mediator.Send(getByIdCountryQuery);
            if (!result.Success)
                return BadRequest(result.Message);
            return Ok(result);
        }
    }
}