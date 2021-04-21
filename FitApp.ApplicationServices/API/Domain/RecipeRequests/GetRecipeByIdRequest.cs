using FitApp.ApplicationServices.API.Domain.Models;
using FitApp.ApplicationServices.API.Domain.RecipeResponses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitApp.ApplicationServices.API.Domain.RecipeRequests
{
    public class GetRecipeByIdRequest : IRequest<GetRecipeByIdResponse>
    {
        public int Id { get; set; }
    }
}
