using KoalaInventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Data.Data_Seeds
{
    public static class WareHousesSeed
    {
        public static List<WareHouse> WareHouses { get; private set; } = new List<WareHouse>()
        {
            new WareHouse() {Id = 1, Name = "SwiftStore"},
            new WareHouse() {Id = 2, Name = "OptiStock"},
            new WareHouse() {Id = 3, Name = "Nexus Dist"},
            new WareHouse() {Id = 4, Name = "PrimeSpace"},
            new WareHouse() {Id = 5, Name = "AgileHub"},
        };
    }
}
