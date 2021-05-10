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
            optionsBuilder.UseSqlServer("Server=tcp:fit-app.database.windows.net,1433;Initial Catalog=FitAppStorage;Persist Security Info=False;User ID=mbojda;Password=cwks1905#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            return new FitStorageContext(optionsBuilder.Options);
        }
    }
}
