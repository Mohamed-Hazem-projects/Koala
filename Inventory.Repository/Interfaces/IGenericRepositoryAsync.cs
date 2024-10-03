using Inventory.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repository.Interfaces
{
    public interface IGenericRepositoryAsync<T> where T : BaseEntity
    {
        Task<T> GetbyIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        void AddAsync(T entity);
        void AddRangeAsync(ICollection<T> entities);
    }
}
