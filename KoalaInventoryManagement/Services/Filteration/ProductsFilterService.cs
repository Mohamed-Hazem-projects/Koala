using Inventory.Data.Models;
using Inventory.Repository.Interfaces;
using KoalaInventoryManagement.ViewModels.Products;

namespace KoalaInventoryManagement.Services.Filteration
{
    public class ProductFilterService : IProductFilterService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductFilterService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<ProductViewModel> ProductsPerRole(string userId, string userRole)
        {
            // Retrieve products based on user role
            // This is just a sample logic; adjust according to your requirements
            if (userRole == "Admin")
            {
                return _unitOfWork.Products.GetAll().Select(p => new ProductViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Description = p.Description,
                    SupplierID = (int)p.SupplierId,
                    CategoryID = (int)p.CategoryId
                }).ToList();
            }
            else if (userRole.StartsWith("WHManager"))
            {   
                int warehouseId = _unitOfWork.WareHousesProducts.GetWareHouseIdByUserId(userId);
                 var productss =  _unitOfWork.WareHousesProducts.GetByWarehouseId(warehouseId)
                    .Select(whp => new ProductViewModel
                    {
                        Id = whp.Product.Id,
                        Name = whp.Product.Name,
                        Price = whp.Product.Price,
                        Description = whp.Product.Description,
                        SupplierID = (int)whp.Product.SupplierId,
                        CategoryID = (int)whp.Product.CategoryId
                    }).ToList();
                return productss;
            }

            return null;
        }

        public List<ProductViewModel> FilterData(int wareHouseID, int categoryID, int supplierID, string searchString, string userRole)
        {
            var products = _unitOfWork.Products.GetAll();

            if (wareHouseID > 0)
            {
                products = products.Where(p => p.WareHouseProducts.Any(whp => whp.WareHouseID == wareHouseID));
            }

            if (categoryID > 0)
            {
                products = products.Where(p => p.CategoryId == categoryID);
            }

            if (supplierID > 0)
            {
                products = products.Where(p => p.SupplierId == supplierID);
            }

            if (!string.IsNullOrWhiteSpace(searchString))
            {
                products = products.Where(p => p.Name.Contains(searchString) || p.Description.Contains(searchString));
            }

            return products.Select(p => new ProductViewModel
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Description = p.Description,
                SupplierID = (int)p.SupplierId,
                CategoryID = (int)p.CategoryId,
                Image = p.Image ?? new byte[0], 
                WareHouseID = p.WareHouseProducts.FirstOrDefault()?.WareHouseID ?? 0,
                CurrentStock = p.WareHouseProducts.FirstOrDefault()?.CurrentStock ?? 0,
                MintStock = p.WareHouseProducts.FirstOrDefault()?.MinStock ?? 0,
                MaxStock = p.WareHouseProducts.FirstOrDefault()?.MaxStock ?? 0
            }).ToList();
        }
    }
}
