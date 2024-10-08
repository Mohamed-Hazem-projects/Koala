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
        IEnumerable<WareHouseProduct>? GetProductWareHousesByPrdID(int productID);
        IEnumerable<Product>? GetWareHouseProductsByWHID(int wareHouseID);
        WareHouseProduct? GetWareHouseProduct(int productID, int wareHouseID);

        //Deletes only one record with ProductID and WareHouseID
        bool DeleteOneRecord(int productID, int WareHouseID);
    }
}
