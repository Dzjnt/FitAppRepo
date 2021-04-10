using FitApp.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FitApp.DataAccess.CQRS.Queries
{
    public class GetMenuQuery : QueryBase<Menu>
    {
        public int Id { get; set; }
        public override async Task<Menu> Execute(FitStorageContext context)
        {
            var menu = await context.Menus.FirstOrDefaultAsync(x => x.Id == this.Id);

            return menu;
        }
    }
}
