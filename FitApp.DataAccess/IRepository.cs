using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitApp.DataAccess
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T Get(object obj);
    }
}
