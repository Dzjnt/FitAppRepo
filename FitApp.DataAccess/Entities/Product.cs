using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitApp.DataAccess.Entities
{
    public class Product : EntityBase
    {
        public List<Ingredient> Ingredients { get; set; }
        public string Name { get; set; }
        public DateTime EndDate { get; set; }
        public string Source { get; set; }
        public decimal Price { get; set; }
        public int Capacity { get; set; }
    }
}
