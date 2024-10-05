using Inventory.Data.Models;
using KoalaInventoryManagement.Models;

namespace Inventory.Repository.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        T? GetbyId(int id);
        IEnumerable<T> GetAll();
        bool Add(T entity);
        bool AddRange(ICollection<T> entities);
        bool Update(T entity);
        bool Delete(int id);
    }
}
