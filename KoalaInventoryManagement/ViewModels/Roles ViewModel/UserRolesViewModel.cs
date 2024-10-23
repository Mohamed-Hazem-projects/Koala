using KoalaInventoryManagement.Models;

namespace KoalaInventoryManagement.ViewModels
{
    public class UserRolesViewModel
    {
        public string UserId { get; set; }
        public string FullName { get; set; }
        public List<string> Roles { get; set; }
        public IEnumerable<WareHouse> Warehouses { get; set; } // Change this line
        public int? AssignedWarehouseId { get; set; } // Nullable, because the user might not be assigned to a warehouse
    }

}
