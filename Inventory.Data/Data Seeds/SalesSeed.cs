using Inventory.Data.Models;

namespace Inventory.Data.Data_Seeds
{
    public class SalesSeed
    {
        public static List<Sales> sales { get; set; } = new List<Sales>{
            new Sales
            {
                Id = 1,
                ItemsSold = 5,
                SaleDate = DateTime.Now,
                TotalPrice = 100,
                ProductId = 1,
                WareHouseId = 3
            },
            new Sales
            {
                Id = 2,
                ItemsSold = 10,
                SaleDate = DateTime.Now,
                TotalPrice = 200,
                ProductId = 2,
                WareHouseId = 1
            },
            new Sales
            {
                Id = 3,
                ItemsSold = 15,
                SaleDate = new DateTime(2024,9,5),
                TotalPrice = 300,
                ProductId = 3,
                WareHouseId = 5
            },
            new Sales
            {
                Id = 4,
                ItemsSold = 20,
                SaleDate = new DateTime(2024,10,3),
                TotalPrice = 400,
                ProductId = 4,
                WareHouseId = 2
            },
            new Sales
            {
                Id = 5,
                ItemsSold = 25,
                SaleDate = new DateTime(2024,10,3),
                TotalPrice = 500,
                ProductId = 5,
                WareHouseId = 3
            }
        };
    }
}