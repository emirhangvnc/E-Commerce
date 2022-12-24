using Core.Application.Requests;
using eCommerceLayer.Application.Features.Concrete.Features.Commands.AddFeature;
using eCommerceLayer.Application.Features.Concrete.Features.Commands.DeleteFeature;
using eCommerceLayer.Application.Features.Concrete.Features.Commands.UpdateFeature;
using eCommerceLayer.Application.Features.Concrete.Features.Queries.GetAllFeature;
using eCommerceLayer.Application.Features.Concrete.Features.Queries.GetByIdFeature;
using eCommerceLayer.WebAPI.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceLayer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] FeatureAddCommand featureAddCommand)
        {
            var result = await Mediator.Send(featureAddCommand);
            return Created("", result);
        }

        [HttpPost]
        public async Task<IActionResult> Delete([FromBody] FeatureDeleteCommand featureDeleteCommand)
        {
            var result = await Mediator.Send(featureDeleteCommand);
            return Created("", result);
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromBody] FeatureUpdateCommand featureUpdateCommand)
        {
            var result = await Mediator.Send(featureUpdateCommand);
            return Created("", result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListFeatureQuery getListFeatureQuery = new() { PageRequest = pageRequest };
            var result = await Mediator.Send(getListFeatureQuery);
            if (!result.Success)
                return BadRequest(result.Message);
            return Ok(result);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdFeatureQuery getByIdFeaturesQuery)
        {
            var result = await Mediator.Send(getByIdFeaturesQuery);
            if (!result.Success)
                return BadRequest(result.Message);
            return Ok(result);
        }
    }
}