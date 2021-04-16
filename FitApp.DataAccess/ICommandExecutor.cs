using FitApp.DataAccess.CQRS.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitApp.DataAccess
{
    public interface ICommandExecutor
    {
        Task<TResult> Executor<TParameters, TResult>(CommandBase<TParameters, TResult> command);
    }
}
