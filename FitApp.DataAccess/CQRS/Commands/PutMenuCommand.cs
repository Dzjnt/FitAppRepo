using FitApp.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitApp.DataAccess.CQRS.Commands
{
    public class PutMenuCommand : CommandBase<Menu, Menu>
    {
        public async override Task<Menu> Execute(FitStorageContext fitStorageContext)
        {

            fitStorageContext.Menus.Update(this.Parameter);
            await fitStorageContext.SaveChangesAsync();

            return this.Parameter;
        }
    }
}
