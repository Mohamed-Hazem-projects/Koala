namespace KoalaInventoryManagement.Models.Managers
{
    public interface IManager<T>
    {
        List<T> GetAll();
        T? GetByID(int id);

        bool AddItem(T item);
        bool DeleteItem(int id);
        bool UpdateItem(T item);
    }
}
