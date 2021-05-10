using FitApp.ApplicationServices.API.Domain.UserRequests;
using FitApp.ApplicationServices.API.Domain.UserResponses;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitApp.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ApiControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<ProductsController> _logger;
        public UsersController(IMediator mediator, ILogger<ProductsController> logger) : base(mediator)
        {
            _mediator = mediator;
            _logger.LogInformation("Entered controller");
        }

        [HttpGet]
        [Route("")]
        public Task<IActionResult> GetAll([FromQuery] GetUsersRequest request)
        {
            return this.HandleRequest<GetUsersRequest, GetUsersResponse>(request);
        }
    }
}
