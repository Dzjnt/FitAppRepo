using FitApp.ApplicationServices.API.Domain.RecipeResponses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitApp.ApplicationServices.API.Domain.RecipeRequests
{
   public class PutRecipeRequest : IRequest<PutRecipeResponse>
   {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Kcal { get; set; }
        public TimeSpan PreparationTime { get; set; }
    }
}
