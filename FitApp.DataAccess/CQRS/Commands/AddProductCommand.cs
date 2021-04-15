using FitApp.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitApp.DataAccess.CQRS.Commands
{
    public class AddProductCommand : CommandBase<Product, Product>
    {
        public async override Task<Product> Execute(FitStorageContext fitStorageContext)
        {
            await fitStorageContext.Products.AddAsync(this.Parameter);
            await fitStorageContext.SaveChangesAsync();

            return this.Parameter;
        }
    }
}
