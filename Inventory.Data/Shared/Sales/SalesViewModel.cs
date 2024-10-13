namespace Inventory.Data.Shared.Sales
{
    public class SalesViewModel
    {
        public required int Id { get; set; }
        public required int ItemsSold { get; set; }

        public DateTime SaleDate { get; set; }
        public decimal TotalPrice { get; set; }

        public required int ProductId { get; set; }
        public required int WareHouseId { get; set; }
        public string ProductName { get; set; }
        public string WareHouseName { get; set; }
    }
}