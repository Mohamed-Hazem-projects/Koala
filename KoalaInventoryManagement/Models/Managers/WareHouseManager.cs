using Microsoft.EntityFrameworkCore;
using KoalaInventoryManagement.Models.Context;

namespace KoalaInventoryManagement.Models.Managers
{
    public class WareHouseManager : IManager<WareHouse>
    {
        InventoryDBContext context;

        public WareHouseManager(InventoryDBContext context)
            => this.context = context;

        public bool AddItem(WareHouse item)
        {
            try
            {
                context?.WareHouses?.Add(item);
                if(context?.Entry(item).State == EntityState.Added)
                {
                    context.SaveChanges();
                    return true;
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

        public bool DeleteItem(int id)
        {
            try
            {
                WareHouse? wareHouse = context?.WareHouses?.Find(id);

                if (wareHouse == null)
                {
                    return false;
                }
                else
                {
                    context?.WareHouses?.Remove(wareHouse);
                    if (context?.Entry(wareHouse).State == EntityState.Deleted)
                    {
                        context.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                //log error
                //.......

                return false;
            }
        }

        public List<WareHouse> GetAll()
        {
            try
            {
                List<WareHouse> wareHouses 
                    = context?.WareHouses?.ToList() ?? new List<WareHouse>();

                return wareHouses;
            }
            catch (Exception ex)
            {
                //log error
                //.......

                return new List<WareHouse>();
            }
        }

        public WareHouse? GetByID(int id)
        {
            try
            {
                WareHouse? wareHouse = context?.WareHouses?.Find(id);

                return wareHouse;
            }
            catch (Exception ex)
            {
                //log error
                //.......

                return default;
            }
        }

        public bool UpdateItem(WareHouse item)
        {
            try
            {
                WareHouse? older = context?.WareHouses?.Find(item.ID);
                if(older != null)
                {
                    older.Name = item.Name;
                    if (context?.Entry(older)?.State == EntityState.Modified)
                    {
                        context.SaveChanges();
                        return true;
                    }
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
    }
}
