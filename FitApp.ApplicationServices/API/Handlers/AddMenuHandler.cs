using AutoMapper;
using FitApp.ApplicationServices.API.Domain;
using FitApp.DataAccess;
using FitApp.DataAccess.CQRS;
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
    public class AddMenuHandler : IRequestHandler<AddMenuRequest, AddMenuResponse>
    {
        private readonly ICommandExecutor _commandExecutor;
        private readonly IMapper _mapper;
        public AddMenuHandler(IMapper mapper, ICommandExecutor commandExecutor)
        {
            _commandExecutor = commandExecutor;
            _mapper = mapper;
          }

        public async Task<AddMenuResponse> Handle(AddMenuRequest request, CancellationToken cancellationToken)
        {
            var menu = _mapper.Map<Menu>(request);
            var command = new AddMenuCommand() { Parameter = menu };
            var menuFromDb = await _commandExecutor.Executor(command);

            return new AddMenuResponse
            {
                Data = _mapper.Map<Domain.Models.Menu>(menuFromDb)
            }; 
        }
    }
}
