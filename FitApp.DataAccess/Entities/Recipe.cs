using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitApp.DataAccess.Entities
{
    public class Recipe : EntityBase
    {
        public int? MenuId { get; set; }
        public List<Menu> Menus { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public int UserId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(255)]
        public string Description { get; set; }
 
        public int Kcal { get; set; }
        public TimeSpan PreparationTime { get; set; }
    }
}
