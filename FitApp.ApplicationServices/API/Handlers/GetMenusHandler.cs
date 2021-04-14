using AutoMapper;
using FitApp.DataAccess;
using FitApp.DataAccess.CQRS.Queries;
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
        private readonly IMapper _mapper;
        private readonly IQueryExecutor _queryExecutor;

        public GetMenusHandler(IMapper mapper,IQueryExecutor queryExecutor)
        {
            _queryExecutor = queryExecutor;
            _mapper = mapper;
        }
        public async Task<GetMenusResponse> Handle(GetMenusRequest request, CancellationToken cancellationToken)
        {
            var query = new GetMenusQuery();
            var menus = await _queryExecutor.Execute(query);
            var mappedMenus = _mapper.Map<List<Domain.Models.Menu>>(menus);
     
            var response = new GetMenusResponse()
            {
                Data = mappedMenus
            };
            
            return response;
        }
    }

}
