using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitApp.ApplicationServices.API.Domain
{
    public class AddMenuRequest : IRequest<AddMenuResponse>
    {
       public int Number { get; set; }
    }
}
