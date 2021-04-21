using FitApp.ApplicationServices.API.Domain.RecipeResponses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitApp.ApplicationServices.API.Domain.RecipeRequests
{
    public class DeleteRecipeByIdRequest : IRequest<DeleteRecipeByIdResponse>
    {
       public int Id { get; set; }
    }
}
