using FitApp.ApplicationServices.API.Domain.MenuResponses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitApp.ApplicationServices.API.Domain.MenuRequests
{
    public class DeleteMenuRequest : IRequest<DeleteMenuResponse>
    {
        public int Number { get; set; }
    }
}
