using FitApp.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitApp.DataAccess.CQRS.Queries
{
    public class GetUserQuery : QueryBase<User>
    {

        public string UserName { get; set; }
        public override async Task<User> Execute(FitStorageContext context)
        {
            var user = await context.Users.FirstOrDefaultAsync(x => x.UserName == this.UserName);

            return user;
        }
    }
}
