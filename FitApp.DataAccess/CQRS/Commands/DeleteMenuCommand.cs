using FitApp.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitApp.DataAccess.CQRS.Commands
{
    public class DeleteMenuCommand : CommandBase<Menu, Menu>
    {
        public async override Task<Menu> Execute(FitStorageContext fitStorageContext)
        {
            fitStorageContext.Remove(this.Parameter);
            await fitStorageContext.SaveChangesAsync();

            return this.Parameter;
        }
    }
}
