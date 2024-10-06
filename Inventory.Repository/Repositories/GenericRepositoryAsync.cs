using Inventory.Data.Context;
using Inventory.Data.Models;
using Inventory.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Repository.Repositories
{
    public class GenericRepositoryAsync<T> : IGenericRepositoryAsync<T> where T : BaseEntity
    {
        private readonly InventoryDbContext _context;
        public GenericRepositoryAsync(InventoryDbContext context)
        {
            _context = context;
        }

        public async Task<T> GetbyIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }
        public async Task AddRangeAsync(ICollection<T> entities)
        {
            await _context.Set<T>().AddRangeAsync(entities);
        }
        // Async Update method without SaveChangesAsync
        public Task UpdateAsync(T entity)
        {
            var existingEntity = _context.Set<T>()?.Local.FirstOrDefault(e => e.Id == entity.Id);

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
                    _context?.Entry(existingEntity).CurrentValues.SetValues(entity);
                }
                else
                {
                    return Task.CompletedTask;
                }
            }
            return Task.CompletedTask;
        }

        // Async Delete method without SaveChangesAsync
        public Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            return Task.CompletedTask;
        }

        // Async Delete by Id method without SaveChangesAsync
        public async Task DeleteByIdAsync(int id)
        {
            var entity = await GetbyIdAsync(id);
            if (entity != null)
            {
                await DeleteAsync(entity);
            }
        }
    }
}
