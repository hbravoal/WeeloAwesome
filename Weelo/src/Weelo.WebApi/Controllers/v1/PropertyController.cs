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

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await Mediator.Send(new GetProductByIdQuery { Id = id }));
        }

        // POST api/<controller>
        [HttpPost]
        //[Authorize]
        public async Task<IActionResult> Post(CreatePropertyCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        //[Authorize]
        public async Task<IActionResult> Put(int id, UpdateProductCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }
            return Ok(await Mediator.Send(command));
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        //[Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await Mediator.Send(new DeleteProductByIdCommand { Id = id }));
        }
    }
}
