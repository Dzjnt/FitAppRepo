using FitApp.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitApp.DataAccess.CQRS.Queries
{
    public class GetRecipesQuery : QueryBase<List<Recipe>>
    {
        public string Name { get; set; }
        public override Task<List<Recipe>> Execute(FitStorageContext context)
        {
            return  context.Recipes.Where(x => x.Name != null && x.Name == this.Name ).ToListAsync();
        }
    }
}
