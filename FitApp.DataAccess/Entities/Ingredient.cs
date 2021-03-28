using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitApp.DataAccess.Entities
{
    public class Ingredient : EntityBase
    {
        public int ProductId { get; set; }
        public int RecipeId { get; set; }
       
        public string Name { get; set; }
        public float Protein { get; set; }
        public float Carbs { get; set; }
        public float Fats { get; set; }
        public string Unit { get; set; }


    }
}

