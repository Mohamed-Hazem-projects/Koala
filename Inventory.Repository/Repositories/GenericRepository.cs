using Inventory.Data.Context;
using Inventory.Data.Models;
using Inventory.Repository.Interfaces;
using KoalaInventoryManagement.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Inventory.Repository.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        protected InventoryDbContext _context;

        public GenericRepository(InventoryDbContext context)
        {
            _context = context;
        }

        public virtual T? GetbyId(int id)
        {
            try
            {
                return _context?.Set<T>()?.Find(id);
            }
            catch (Exception ex)
            {
                //log error
                //.......

                return default;
            }
        }

        public virtual IEnumerable<T> GetAll()
        {
            try
            {
                List<T> result = _context?.Set<T>()?.ToList() ?? new List<T>();
                return result;
            }
            catch (Exception ex)
            {
                //log error
                //.......

                return new List<T>();
            }
        }
        public IEnumerable<T> FindByName(Expression<Func<T, bool>> match, string[] includes = null)
        {
            IQueryable<T> query = _context.Set<T>();
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }

            }
            return query.Where(match).ToList();
        }

        
        public virtual bool Add(T entity)
        {
            try
            {
                _context?.Set<T>()?.Add(entity);
                if (_context?.Entry(entity)?.State == EntityState.Added)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                //log error
                //.......

                return false;
            }
        }

        public virtual bool AddRange(ICollection<T> entities)
        {
            try
            {
                _context.Set<T>().AddRange(entities);
                if (_context?.Entry(entities)?.State == EntityState.Added)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                //log error
                //.......

                return false;
            }
        }

        public virtual bool Update(T entity)
        {
            try
            {
                // Check if the entity is already tracked
                var existingEntity = _context?.Set<T>()?.Local.FirstOrDefault(e => e.Id == entity.Id);

                if (existingEntity != null)
                {
                    // If the entity is already being tracked, update its properties
                    _context.Entry(existingEntity).CurrentValues.SetValues(entity);
                }
                else
                {
                    // If it's not tracked, find the entity in the database
                    existingEntity = _context?.Set<T>()?.Find(entity.Id);

                    if (existingEntity != null)
                    {
                        // Update the existing entity's properties
                        _context.Entry(existingEntity).CurrentValues.SetValues(entity);
                    }
                    else
                    {
                        // If no existing entity found, add the new one
                        _context?.Set<T>()?.Add(entity);
                    }
                }

                // Save changes to the context
                return true;
              
            }
            catch (Exception ex)
            {
                // Log the error
                //.......

                return false;
            }
        }


        public virtual bool Delete(int id)
        {
            try
            {
                T? existing = _context?.Set<T>()?.Find(id);

                if (existing != null)
                {
                    _context?.Set<T>()?.Remove(existing);

                    if (_context?.Entry(existing).State == EntityState.Deleted)
                        return true;
                    else
                        return false;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                //log error
                //.......

                return false;
            }
        }
    }
}
