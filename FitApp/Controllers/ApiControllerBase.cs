using Microsoft.AspNetCore.Mvc;
using MediatR;
using FitApp.ApplicationServices.API.Domain;
using System.Threading.Tasks;
using System.Linq;

namespace FitApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiControllerBase : ControllerBase
    {
        protected readonly IMediator _mediator;
        protected ApiControllerBase(IMediator mediator)
        {
            _mediator = mediator;
        }

        protected async Task<IActionResult> HandleRequest<TRequest,TResponse>(TRequest request)
            where TRequest : IRequest<TResponse>
            where TResponse : ErrorResponseBase
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(
                    ModelState
                    .Where(x => x.Value.Errors.Any())
                    .Select(x => new { property = x.Key, errors = x.Value.Errors }));
            }

            var response = await _mediator.Send(request);
            if(response.Error != null)
            {

            }

            return Ok(response);
        }
    }
}
