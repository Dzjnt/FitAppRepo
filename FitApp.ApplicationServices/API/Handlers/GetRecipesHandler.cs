using AutoMapper;
using FitApp.ApplicationServices.API.Domain;
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
    public class GetRecipesHandler : IRequestHandler<GetRecipesRequest, GetRecipesResponse>
    {
        
        private readonly IMapper _mapper;
        private readonly IQueryExecutor _queryExecutor;

        public GetRecipesHandler(IMapper mapper, IQueryExecutor queryExecutor)
        {
            _queryExecutor = queryExecutor;
            _mapper = mapper;
        }
        public async Task<GetRecipesResponse> Handle(GetRecipesRequest request, CancellationToken cancellationToken)
        {
            var query = new GetRecipesQuery()
            {
                Name = request.Name
            };
            var recipes = await _queryExecutor.Execute(query);
            var mappedRecipes = _mapper.Map<List<Domain.Models.Recipe>>(recipes);

            var response = new GetRecipesResponse()
            {
                Data = mappedRecipes
            };

            return response;
        }
    }

}

