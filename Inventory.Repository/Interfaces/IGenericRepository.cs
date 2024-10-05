using Inventory.Data.Models;

namespace Inventory.Repository.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        T? GetbyId(int id);
        IEnumerable<T> GetAll();
        bool Add(T entity);
        bool AddRange(ICollection<T> entities);
        bool Update(T entity);
        bool Delete(int id);
    }
}
