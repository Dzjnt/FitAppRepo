using FitApp.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitApp.DataAccess.CQRS.Commands
{
    public class AddSharedMenuCommand : CommandBase<SharedMenu, SharedMenu>
    {
        public async override Task<SharedMenu> Execute(FitStorageContext fitStorageContext)
        {
            await fitStorageContext.SharedMenus.AddAsync(this.Parameter);
            await fitStorageContext.SaveChangesAsync();

            return this.Parameter;
        }
    }
}
