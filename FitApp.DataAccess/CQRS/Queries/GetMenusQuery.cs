using FitApp.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitApp.DataAccess.CQRS.Queries
{
    public class GetMenusQuery : QueryBase<List<Menu>>
    {
        public override  Task<List<Menu>> Execute(FitStorageContext context) =>  context.Menus.ToListAsync();
    
    }
}
