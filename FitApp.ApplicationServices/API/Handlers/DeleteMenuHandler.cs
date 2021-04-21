using AutoMapper;
using FitApp.ApplicationServices.API.Domain.MenuRequests;
using FitApp.ApplicationServices.API.Domain.MenuResponses;
using FitApp.DataAccess;
using FitApp.DataAccess.CQRS.Commands;
using FitApp.DataAccess.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FitApp.ApplicationServices.API.Handlers
{
    public class DeleteMenuHandler : IRequestHandler<DeleteMenuRequest, DeleteMenuResponse>
    {
        private readonly IMapper _mapper;
        private readonly ICommandExecutor _commandExecutor;

        public DeleteMenuHandler(IMapper mapper, ICommandExecutor commandExecutor)
        {
            _commandExecutor = commandExecutor;
            _mapper = mapper;
        }
        public async Task<DeleteMenuResponse> Handle(DeleteMenuRequest request, CancellationToken cancellationToken)
        {
            var menuToDelete = _mapper.Map<Menu>(request);
            var command = new DeleteMenuCommand() { Parameter = menuToDelete };
            var menuFromDb = await _commandExecutor.Executor(command);

            var response = new DeleteMenuResponse()
            {
                Data = _mapper.Map<Domain.Models.Menu>(menuFromDb)
            };

            return response;
        }
    }
}
