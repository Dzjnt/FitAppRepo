using AutoMapper;
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
        private readonly IMapper _mapper;
        public GetMenuHandler(IRepository<FitApp.DataAccess.Entities.Menu> menuRepository, IMapper mapper)
        {
            _menuRepository = menuRepository;
            _mapper = mapper;
        }
        public async Task<GetMenuResponse> Handle(GetMenuRequest request, CancellationToken cancellationToken)
        {
            var menu = await _menuRepository.GetById(request.Id);
            var mappedMenu =  _mapper.Map<Domain.Models.Menu>(menu);

            var response = new GetMenuResponse()
            {
                Data = mappedMenu

            };

            return response;
        }
    }
}
