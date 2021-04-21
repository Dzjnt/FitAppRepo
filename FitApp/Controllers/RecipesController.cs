using FitApp.ApplicationServices.API.Domain;
using FitApp.ApplicationServices.API.Domain.RecipeRequests;
using FitApp.DataAccess;
using FitApp.DataAccess.Entities;
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
    public class RecipesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public RecipesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAll(GetRecipesRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet]
        [Route("{recipeId}")]
        public async Task<IActionResult> GetById([FromRoute] int recipeId)
        {
            var request = new GetRecipeByIdRequest()
            {
                Id = recipeId
            };
            var response = await _mediator.Send(request);

            return Ok(response);

        }
    
        [HttpPut]
        [Route("{recipeId}")]
        public async Task<IActionResult> Put([FromBody] PutRecipeRequest request, int recipeId)
        {

            request.Id = recipeId;
            var response = await _mediator.Send(request);

            return Ok(response);
        }

        [HttpDelete]
        [Route("{recipeId}")]
        public async Task<IActionResult> Delete([FromRoute] int recipeId)
        {
            var request = new DeleteRecipeByIdRequest()
            {
                Id = recipeId
            };
            var response = await _mediator.Send(request);

            return Ok(response);

        }
    }
}
