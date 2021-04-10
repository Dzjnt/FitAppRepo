using FitApp.ApplicationServices.API.Domain;
using FitApp.ApplicationServices.API.Domain.Models;
using FitApp.DataAccess;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FitApp.ApplicationServices.API.Handlers
{
    public class GetMenuHandler : IRequestHandler<GetMenuRequest, GetMenuResponse>
    {
        private readonly IRepository<FitApp.DataAccess.Entities.Menu> _menuRepository;
        public GetMenuHandler(IRepository<FitApp.DataAccess.Entities.Menu> menuRepository)
        {
            _menuRepository = menuRepository;
        }
        public Task<GetMenuResponse> Handle(GetMenuRequest request, CancellationToken cancellationToken)
        {
            var result = _menuRepository.GetById(request.Id);

            var response = new GetMenuResponse()
            {
                Data = new Menu()
                {
                    Id = result.Id,
                    UserId = result.UserId
                }
            };
            return Task.FromResult(response);
        }
    }
}
