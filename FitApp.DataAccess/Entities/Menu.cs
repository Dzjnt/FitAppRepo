using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitApp.DataAccess.Entities
{
    public class Menu : EntityBase
    {

        public List<Recipe> Recipes { get; set; }
        public int UserId { get; set; }

    }
}
