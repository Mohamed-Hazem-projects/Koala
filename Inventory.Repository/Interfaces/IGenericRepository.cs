using Inventory.Data.Models;
using KoalaInventoryManagement.Models;
using System.Linq.Expressions;

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
        IEnumerable<T> FindByName(Expression<Func<T, bool>> match, string[] includes = null);

        T? GetbyId(int id, string[] includes);
        IEnumerable<T> GetAll(string[] includes);
    }
}
