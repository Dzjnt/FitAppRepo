using AutoMapper;
using FitApp.ApplicationServices.API.Domain;
using FitApp.ApplicationServices.API.Domain.Models;
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
    public class GetMenuHandler : IRequestHandler<GetMenuRequest, GetMenuResponse>
    {
        private readonly IQueryExecutor _queryExecutor;
        private readonly IMapper _mapper;
        public GetMenuHandler(IMapper mapper, IQueryExecutor queryExecutor)
        {
            _queryExecutor = queryExecutor;
            _mapper = mapper;
        }
        public async Task<GetMenuResponse> Handle(GetMenuRequest request, CancellationToken cancellationToken)
        {
            var query = new GetMenuQuery
            {
                Id = request.Id
            };
            var menu = await _queryExecutor.Execute(query);
            var mappedMenu =  _mapper.Map<Domain.Models.Menu>(menu);

            var response = new GetMenuResponse()
            {
                Data = mappedMenu

            };

            return response;
        }
    }
}
