using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitApp.ApplicationServices.API.Domain
{
    public class GetMenuRequest : IRequest<GetMenuResponse>
    {
        public int Id { get; set; }
    }
}
