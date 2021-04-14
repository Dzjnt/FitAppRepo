using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitApp.ApplicationServices.API
{
    public class GetMenusRequest : IRequest<GetMenusResponse>
    {
        public int Id { get; set; }
    }
}
