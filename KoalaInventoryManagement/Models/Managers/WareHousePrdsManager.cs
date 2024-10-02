
using KoalaInventoryManagement.Models.Context;
using Microsoft.EntityFrameworkCore;

namespace KoalaInventoryManagement.Models.Managers
{
    public class WareHousePrdsManager
    {
        InventoryDBContext context;

        public WareHousePrdsManager(InventoryDBContext context)
            => this.context = context;


        public bool AddItem(WareHouseProduct item)
        {
            try
            {
                context?.WareHouseProducts?.Add(item);
                if (context?.Entry(item).State == EntityState.Added)
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

        public bool DeleteItem(int productID, int WareHouseID)
        {
            try
            {
                WareHouseProduct? wareHousePrd 
                    = context?.WareHouseProducts?.Find(productID, WareHouseID);

                if (wareHousePrd == null)
                {
                    return false;
                }
                else
                {
                    context?.WareHouseProducts?.Remove(wareHousePrd);
                    if (context?.Entry(wareHousePrd).State == EntityState.Deleted)
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

        public List<WareHouseProduct> GetAll()
        {
            try
            {
                List<WareHouseProduct> wareHousesPrds
                    = context?.WareHouseProducts?
                              .Include(whp => whp.Product)
                              .Include(whp => whp.WareHouse)
                              .ToList() ?? new List<WareHouseProduct>();

                return wareHousesPrds;
            }
            catch (Exception ex)
            {
                //log error
                //.......

                return new List<WareHouseProduct>();
            }
        }

        public List<WareHouse>? GetProductWareHousesByPrdID(int productID)
        {
            try
            {
                List<WareHouse>? productWareHouses
                    = context?.WareHouseProducts?
                              .Include(whp => whp.WareHouse)
                              .Where(whp => whp.ProductID == productID)
                              .Select(whp => whp.WareHouse)
                              .ToList();

                return productWareHouses;
            }
            catch (Exception ex)
            {
                //log error
                //.......

                return default;
            }
        }

        public List<Product>? GetWareHouseProductsByWHID(int wareHouseID)
        {
            try
            {
                List<Product>? wareHouseProducts
                    = context?.WareHouseProducts?
                              .Include(whp => whp.Product)
                              .Where(whp => whp.WareHouseID == wareHouseID)
                              .Select(whp => whp.Product)
                              .ToList();

                return wareHouseProducts;
            }
            catch (Exception ex)
            {
                //log error
                //.......

                return default;
            }
        }

        public bool UpdateItem(WareHouseProduct item)
        {
            try
            {
                WareHouseProduct? older 
                    = context?.WareHouseProducts?.Find(item.ProductID, item.WareHouseID);

                if (older != null)
                {
                    older.MinStock = item.MinStock;
                    older.CurrentStock = item.CurrentStock;
                    older.MaxStock = item.MaxStock;
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
