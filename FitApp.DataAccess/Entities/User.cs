using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitApp.DataAccess.Entities
{
    public class User : EntityBase
    {
        public IList<Stat> Stats { get; set; }
        public int? RecipeId { get; set; }
        public IList<Recipe> Recipes { get; set; }
        public IList<Menu> Menus { get; set; }
        public int StatId { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
    }
}
