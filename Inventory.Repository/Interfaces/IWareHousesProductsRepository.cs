using KoalaInventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repository.Interfaces
{
    public interface IWareHousesProductsRepository : IGenericRepository<WareHouseProduct>
    {
        IEnumerable<WareHouse>? GetProductWareHousesByPrdID(int productID);
        IEnumerable<Product>? GetWareHouseProductsByWHID(int wareHouseID);
        WareHouseProduct? GetWareHouseProduct(int productID, int wareHouseID);
        IEnumerable<WareHouseProduct>? GettWareHousesProductsByPrdID(int productID, string[]? includes = null);

        //Deletes only one record with ProductID and WareHouseID
        bool DeleteOneRecord(int productID, int wareHouseID);
    }
}
