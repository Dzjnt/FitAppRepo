using FitApp.ApplicationServices.API;
using FitApp.ApplicationServices.API.Domain;
using FitApp.ApplicationServices.API.Domain.MenuRequests;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenusController : ApiControllerBase
    {

        public MenusController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetMenus([FromQuery] GetMenusRequest request)
        {
            return await this.HandleRequest<GetMenusRequest, GetMenusResponse>(request);
        }
    
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> AddMenu([FromBody] AddMenuRequest request)
        {
            return await this.HandleRequest<AddMenuRequest, AddMenuResponse>(request);  
        }
        [HttpPut]
        [Route("")]
        public async Task<IActionResult> UpdateMenu([FromQuery] GetMenusRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
        [HttpDelete]
        [Route("menuId")]
        public async Task<IActionResult> DeleteMenu([FromQuery] int menuId)
        {
            var request = new DeleteMenuRequest()
            {
                Number = menuId
            };
            var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
