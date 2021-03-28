using FitApp.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitApp.DataAccess
{
    public class FitStorageContext : DbContext
    {
        public FitStorageContext(DbContextOptions<FitStorageContext> options) : base(options)
        {

        }
   
        public DbSet<Recipe> Recipes { get; set; }  
        public DbSet<User> Users { get; set; } 
        public DbSet<Menu> Menus { get; set; }
        public DbSet<SharedMenu> SharedMenus { get; set; }
        public DbSet<Stat> Stats { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Product> Products { get; set; }
     
    }
}
