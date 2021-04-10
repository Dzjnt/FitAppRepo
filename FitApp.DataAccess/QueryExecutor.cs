using FitApp.DataAccess.CQRS.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitApp.DataAccess
{
    public class QueryExecutor : IQueryExecutor
    {
        private readonly FitStorageContext _context;
        public QueryExecutor(FitStorageContext context)
        {
            _context = context;
        }
        public Task<TResult> Execute<TResult>(QueryBase<TResult> query)
        {
            return query.Execute(_context);
        }
    }
}
