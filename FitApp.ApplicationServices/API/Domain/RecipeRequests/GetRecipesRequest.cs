using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitApp.ApplicationServices.API.Domain
{
    public class GetRecipesRequest : IRequest<GetRecipesResponse>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
