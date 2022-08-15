using IcreCreamParlour.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcreCreamParlour.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DbIcecreamParlourContext _context;
        private readonly DbSet<T> _entities;

        public GenericRepository(DbIcecreamParlourContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.AsEnumerable();
        }

        public T FindById(int id)
        {
            return _entities.Find(id);
        }

        public void Insert(T entity)
        {
            _entities.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _entities.Update(entity);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var entity = _entities.Find(id);
            _entities.Remove(entity);
            _context.SaveChanges();
        }
    }
}
