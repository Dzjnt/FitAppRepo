using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitApp.DataAccess.Entities
{
    public class Stat : EntityBase
    { 
        public int UserId { get; set; }
        public  decimal Weigh { get; set; }
        public DateTime Date { get; set; }
    }
}
