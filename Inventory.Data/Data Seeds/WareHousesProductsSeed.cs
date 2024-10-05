using KoalaInventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Data.Data_Seeds
{
    public static class WareHousesProductsSeed
    {
        public static List<WareHouseProduct> WareHouseProducts { get; set; } 
            = new List<WareHouseProduct>()
            {
                new WareHouseProduct()
                {ProductID = 1, WareHouseID = 1, MinStock = 10, CurrentStock = 20, MaxStock = 50},
                new WareHouseProduct()
                {ProductID = 1, WareHouseID = 2, MinStock = 5, CurrentStock = 15, MaxStock = 40},
                new WareHouseProduct()
                {ProductID = 2, WareHouseID = 3, MinStock = 7, CurrentStock = 12, MaxStock = 30},
                new WareHouseProduct()
                {ProductID = 2, WareHouseID = 1, MinStock = 3, CurrentStock = 8, MaxStock = 25},
                new WareHouseProduct()
                {ProductID = 3, WareHouseID = 2, MinStock = 4, CurrentStock = 5, MaxStock = 10},
                new WareHouseProduct()
                {ProductID = 3, WareHouseID = 3, MinStock = 15, CurrentStock = 20, MaxStock = 50},
            };
    }
}
