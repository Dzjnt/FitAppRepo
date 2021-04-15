using FitApp.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitApp.DataAccess.CQRS.Commands
{
    public class AddRecipeCommand : CommandBase<Recipe, Recipe>
    {
        public async override Task<Recipe> Execute(FitStorageContext fitStorageContext)
        {
            await fitStorageContext.Recipes.AddAsync(this.Parameter);
            await fitStorageContext.SaveChangesAsync();

            return this.Parameter;
        }
    }
}
