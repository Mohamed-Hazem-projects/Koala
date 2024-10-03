using Inventory.Data.Models;

namespace Inventory.Repository.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        T GetbyId(int id);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void AddRange(ICollection<T> entities);
        void Update(T entity);
        void Delete(int id);
    }
}
