using AutoMapper;
using FitApp.ApplicationServices.API.Domain.RecipeRequests;
using FitApp.ApplicationServices.API.Domain.RecipeResponses;
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
    public class GetRecipeByIdById : IRequestHandler<GetRecipeByIdRequest, GetRecipeByIdResponse>
    {

        private readonly IMapper _mapper;
        private readonly IQueryExecutor _queryExecutor;

        public GetRecipeByIdById(IMapper mapper, IQueryExecutor queryExecutor)
        {
            _queryExecutor = queryExecutor;
            _mapper = mapper;
        }
        public async Task<GetRecipeByIdResponse> Handle(GetRecipeByIdRequest request, CancellationToken cancellationToken)
        {
            var query = new GetRecipeQuery()
            {
                Id = request.Id
            };
            var recipe = await _queryExecutor.Execute(query);
            var mappedRecipe = _mapper.Map<Domain.Models.Recipe>(recipe);

            var response = new GetRecipeByIdResponse()
            {
                Data = mappedRecipe
            };

            return response;
        }
    }
}
