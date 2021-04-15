using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitApp.DataAccess.CQRS.Commands
{
    public abstract class CommandBase<TParameter,TResult>
    {
        public TParameter Parameter { get; set; }

        public abstract Task<TResult> Execute(FitStorageContext fitStorageContext);
    }
}
