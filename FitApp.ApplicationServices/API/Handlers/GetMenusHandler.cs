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
    public class GetMenusHandler : IRequestHandler<GetMenusRequest, GetMenusResponse>
    {
        private readonly IRepository<FitApp.DataAccess.Entities.Menu> _menuRepository;
        public GetMenusHandler(IRepository<FitApp.DataAccess.Entities.Menu> menuRepository)
        {
            _menuRepository = menuRepository;
        }
        public Task<GetMenusResponse> Handle(GetMenusRequest request, CancellationToken cancellationToken)
        {
            var menus = _menuRepository.GetAll();
            var domainMenus = menus.Select(m => new Domain.Models.Menu()
            {
                Id = m.Id,
                UserId = m.UserId

            });

            var response = new GetMenusResponse()
            {
                Data = domainMenus.ToList()
            };
            
            return Task.FromResult(response);
        }
    }

}
