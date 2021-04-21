using FitApp.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitApp.DataAccess.CQRS.Queries
{
    public class GetRecipeQuery: QueryBase<Recipe>   
    {
        public int Id { get; set; }
        public override async Task<Recipe> Execute(FitStorageContext context)
        {
            var recipe = await context.Recipes.FirstOrDefaultAsync(x => x.Id == this.Id);

            return recipe;
        }
    }
}
