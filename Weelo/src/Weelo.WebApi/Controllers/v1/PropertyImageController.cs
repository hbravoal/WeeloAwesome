using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
namespace Weelo.WebApi.Controllers.v1
{
    public class PropertyImageController : BaseApiController
    {

      
        // POST api/<controller>
        [HttpPost]
        //[Authorize]
        public async Task<IActionResult> Post([FromForm]Application.Features.PropertiesImage.Commands.Create.CreatePropertyImageCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

       
    }
}
