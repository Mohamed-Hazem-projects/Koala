using Inventory.Repository.Interfaces;
using KoalaInventoryManagement.Models;
using KoalaInventoryManagement.Services.Filteration;
using KoalaInventoryManagement.ViewModels.Products;
using Newtonsoft.Json;

namespace KoalaInventoryManagement.Services
{
    public class ProductsFilterService : IProductFilterService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductsFilterService(IUnitOfWork unitOfWork)
            => _unitOfWork = unitOfWork;

        public List<ProductViewModel> FilterData(int wareHouseID, int categoryID, int supplierID, string searchString, string role)
        {
            //LoggedRole loggedRole = LoggedRole.Admin;
            int wareHouseIdForManager = 0;

            if (!string.IsNullOrEmpty(role))
                if (role.StartsWith("WHManager"))
                    int.TryParse(role.Substring("WHManager".Length), out wareHouseIdForManager);

            List<ProductViewModel> productsViewModel = ProductsPerRole(wareHouseIdForManager);

            var filteredProducts = productsViewModel.AsQueryable();

            if (wareHouseID > 0)
            {
                filteredProducts = filteredProducts.Where(s => s.WareHouseID == wareHouseID);
            }
            if (categoryID > 0)
            {
                filteredProducts = filteredProducts.Where(s => s.CategoryID == categoryID);
            }
            if (supplierID > 0)
            {
                filteredProducts = filteredProducts.Where(s => s.SupplierID == supplierID);
            }
            if (!string.IsNullOrEmpty(searchString))
            {
                filteredProducts = filteredProducts.Where(s => s.Name.ToLower().Contains(searchString.ToLower()));
            }

            return filteredProducts.ToList();
        }

        public List<ProductViewModel> ProductsPerRole(int wareHouseId)
        {
            List<Product> products;

            if (wareHouseId > 0)
            {
                products = _unitOfWork?.Products?
                              .GetAll(new[] { "Supplier", "Category", "WareHouseProducts" })?
                              .Where(p => p.WareHouseProducts.Any(whp => whp.WareHouseID == wareHouseId))
                              .ToList()
                                ?? new List<Product>();
            }
            else
            {
                products = _unitOfWork?.Products?.GetAll(new[] { "Supplier", "Category", "WareHouseProducts" })?.ToList()
                    ?? new List<Product>();
            }

            List<WareHouse> wareHouses = _unitOfWork?.WareHouses?.GetAll()?.ToList() ?? new List<WareHouse>();
            List<ProductViewModel> productsViewModel = new List<ProductViewModel>();

            foreach (Product p in products)
            {
                foreach (WareHouseProduct whp in p.WareHouseProducts)
                {
                    productsViewModel.Add(new ProductViewModel()
                    {
                        Id = p.Id,
                        Name = p.Name,
                        Description = p.Description,
                        Price = p.Price,
                        Image = p.Image ?? new byte[0], // Use an empty byte array for image
                        WareHouseID = whp?.WareHouseID ?? 0,
                        WareHouseName = wareHouses?.Find(w => w.Id == whp?.WareHouseID)?.Name ?? string.Empty,
                        CurrentStock = whp?.CurrentStock ?? 0,
                        MintStock = whp?.MinStock ?? 0,
                        MaxStock = whp?.MaxStock ?? 0,
                        CategoryID = p?.CategoryId ?? 0,
                        CategoryName = p?.Category?.Name ?? string.Empty,
                        SupplierID = p?.SupplierId ?? 0,
                        SupplierName = p?.Supplier?.Name ?? string.Empty,
                    });
                }
            };

            return productsViewModel;
        }
    }
}
