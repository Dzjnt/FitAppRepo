using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitApp.DataAccess
{
    public class FitStorageContextFactory : IDesignTimeDbContextFactory<FitStorageContext>
    {
        public FitStorageContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<FitStorageContext>();
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=FitStorage;Integrated Security=True");
            return new FitStorageContext(optionsBuilder.Options);
        }
    }
}
