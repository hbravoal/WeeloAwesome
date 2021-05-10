using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Weelo.Application.Features.Products.Commands.DeleteProductById;
using Weelo.Application.Features.Products.Commands.UpdateProduct;

using Weelo.Application.Features.Products.Queries.GetProductById;
using Weelo.Application.Features.Properties.Commands.Create;

namespace Weelo.WebApi.Controllers.v1
{
    public class PropertyController : BaseApiController
    {
        
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] Application.Features.Properties.Queries.GetAll.GetAllPropertiesQuery filter)
        {

            return Ok(await Mediator.Send(new Application.Features.Properties.Queries.GetAll.GetAllPropertiesQuery() { PageSize = filter.PageSize, PageNumber = filter.PageNumber }));
        }

        // POST api/<controller>
        [HttpPost]
        //[Authorize]
        public async Task<IActionResult> Post(CreatePropertyCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

    }
}
