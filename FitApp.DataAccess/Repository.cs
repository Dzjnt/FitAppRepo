using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitApp.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace FitApp.DataAccess
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
      
        private readonly  FitStorageContext _context;
        private DbSet<T> _entities;
        public Repository(FitStorageContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }
        public IEnumerable<T> GetAll() => _entities.AsEnumerable();

        public T GetById(int id) => _entities.SingleOrDefault(s => s.Id == id);

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentException("Entity cannot be null");
            }
            _entities.Add(entity);
            _context.SaveChanges();

        }          
        public void Update(T entity)
        {

            if (entity == null)
            {
                throw new ArgumentException("Entity cannot be null");
            }

            _context.Update(entity);
            _context.SaveChanges();

        }
        public void Delete(int id)
        {
            T entity = _entities.SingleOrDefault(s => s.Id == id);
            _entities.Remove(entity);
            _context.SaveChanges();
        }

    }
}
