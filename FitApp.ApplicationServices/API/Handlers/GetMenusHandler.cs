using AutoMapper;
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
        private readonly IMapper _mapper;
        public GetMenusHandler(IRepository<FitApp.DataAccess.Entities.Menu> menuRepository, IMapper mapper)
        {
            _menuRepository = menuRepository;
            _mapper = mapper;
        }
        public async Task<GetMenusResponse> Handle(GetMenusRequest request, CancellationToken cancellationToken)
        {
            var menus = await _menuRepository.GetAll();
            var mappedMenus = _mapper.Map<List<Domain.Models.Menu>>(menus);
     
            var response = new GetMenusResponse()
            {
                Data = mappedMenus
            };
            
            return response;
        }
    }

}
