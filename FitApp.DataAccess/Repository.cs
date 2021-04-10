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
        public Task<List<T>> GetAll() => _entities.ToListAsync();

        public Task<T> GetById(int id) => _entities.SingleOrDefaultAsync(s => s.Id == id);

        public Task Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentException("Entity cannot be null");
            }
            _entities.Add(entity);


            return _context.SaveChangesAsync();

        }          
        public Task Update(T entity)
        {

            if (entity == null)
            {
                throw new ArgumentException("Entity cannot be null");
            }

            _context.Update(entity);

            return _context.SaveChangesAsync();

        }
        public Task Delete(int id)
        {
            T entity = _entities.SingleOrDefault(s => s.Id == id);
            _entities.Remove(entity);

            return _context.SaveChangesAsync();
        }

    }
}
