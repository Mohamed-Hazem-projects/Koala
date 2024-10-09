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

        public IEnumerable<T> FindByName(Expression<Func<T, bool>> match, string[]? includes = null)
        {
            try
            {
                IQueryable<T> query = _context.Set<T>();

                if (includes != null)
                    foreach (var include in includes)
                        query = query.Include(include);

                return query.Where(match).ToList();
            }
            catch (Exception ex)
            {
                //log error
                //.......

                return new List<T>();
            }
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
                T? existingEntity
                    = _context?.Set<T>()?.Local?.FirstOrDefault(e => e.Id == entity.Id);

                if (existingEntity != null)
                {
                    // If the entity is already being tracked, update its properties
                    _context?.Entry(existingEntity)?.CurrentValues.SetValues(entity);

                    if (_context?.Entry(existingEntity)?.State == EntityState.Modified)
                        return true;
                }
                else
                {
                    // If it's not tracked, find the entity in the database
                    existingEntity = _context?.Set<T>()?.Find(entity.Id);

                    if (existingEntity != null)
                    {
                        // Update the existing entity's properties
                        _context?.Entry(existingEntity).CurrentValues.SetValues(entity);

                        if (_context?.Entry(existingEntity)?.State == EntityState.Modified)
                            return true;
                    }
                }

                return false;
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
                }

                return false;
            }
            catch (Exception ex)
            {
                //log error
                //.......

                return false;
            }
        }

        public IEnumerable<T> GetAll(string[] includes)
        {
            try
            {
                IQueryable<T> query = _context.Set<T>();
                if(includes != null && includes.Length > 0)
                    foreach (string include in includes)
                        query = query.Include(include);

                List<T> result = query?.ToList() ?? new List<T>();
                return result;
            }
            catch (Exception ex)
            {
                //log error
                //.......

                return new List<T>();
            }
        }

        public T? GetbyId(int id, string[] includes)
        {
            try
            {
                IQueryable<T> query = _context.Set<T>();
                if (includes != null && includes.Length > 0)
                {
                    foreach (string include in includes)
                        query = query.Include(include);
                }

                return query.FirstOrDefault(e => e.Id == id);
            }
            catch (Exception ex)
            {
                //log error
                //.......

                return default;
            }
        }
    }
}
