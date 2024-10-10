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

        public List<ProductViewModel> FilterData(int wareHouseID, int categoryID, int supplierID, string searchString, string showedProducts)
        {
            List<ProductViewModel>? showedProductsNow = JsonConvert.DeserializeObject<List<ProductViewModel>>(showedProducts);

            if (showedProductsNow == null)
                showedProductsNow = new List<ProductViewModel>();


            if (wareHouseID > 0)
            {
                WareHouse wareHouse = _unitOfWork?.WareHouses?.GetbyId(wareHouseID) ?? new WareHouse();

                if (categoryID > 0)
                {
                    if (supplierID > 0)
                    {
                        if (!string.IsNullOrEmpty(searchString))
                        {
                            List<ProductViewModel> result = showedProductsNow.Where(s => s.WareHouseID == wareHouse.Id)
                                .Where(s => s.CategoryID == categoryID)
                                .Where(s => s.SupplierID == supplierID)
                                .Where(s => s.Name.ToLower().Contains(searchString.ToLower())).ToList();

                            return result;
                        }
                        else
                        {
                            List<ProductViewModel> result = showedProductsNow.Where(s => s.WareHouseID == wareHouse.Id)
                                .Where(s => s.CategoryID == categoryID)
                                .Where(s => s.SupplierID == supplierID)
                                .ToList();
                            return result;
                        }
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(searchString))
                        {
                            List<ProductViewModel> result = showedProductsNow.Where(s => s.WareHouseID == wareHouse.Id)
                                .Where(s => s.CategoryID == categoryID)
                                .Where(s => s.Name.ToLower().Contains(searchString.ToLower())).ToList();

                            return result;
                        }
                        else
                        {
                            List<ProductViewModel> result = showedProductsNow.Where(s => s.WareHouseID == wareHouse.Id)
                                .Where(s => s.CategoryID == categoryID)
                                .ToList();
                            return result;
                        }
                    }
                }
                else
                {
                    if (supplierID > 0)
                    {
                        if (!string.IsNullOrEmpty(searchString))
                        {
                            List<ProductViewModel> result = showedProductsNow.Where(s => s.WareHouseID == wareHouse.Id)
                                .Where(s => s.SupplierID == supplierID)
                                .Where(s => s.Name.ToLower().Contains(searchString.ToLower())).ToList();

                            return result;
                        }
                        else
                        {
                            List<ProductViewModel> result = showedProductsNow.Where(s => s.WareHouseID == wareHouse.Id)
                                .Where(s => s.SupplierID == supplierID).ToList();
                            return result;
                        }
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(searchString))
                        {
                            List<ProductViewModel> result = showedProductsNow.Where(s => s.WareHouseID == wareHouse.Id)
                                .Where(s => s.Name.ToLower().Contains(searchString.ToLower())).ToList();

                            return result;
                        }
                        else
                        {
                            List<ProductViewModel> result = showedProductsNow.Where(s => s.WareHouseID == wareHouse.Id).ToList();
                            return result;
                        }
                    }
                }
            }
            else
            {
                if (categoryID > 0)
                {
                    if (supplierID > 0)
                    {
                        if (!string.IsNullOrEmpty(searchString))
                        {
                            List<ProductViewModel> result = showedProductsNow.Where(s => s.CategoryID == categoryID)
                                .Where(s => s.SupplierID == supplierID)
                                .Where(s => s.Name.ToLower().Contains(searchString.ToLower())).ToList();

                            return result;
                        }
                        else
                        {
                            List<ProductViewModel> result = showedProductsNow.Where(s => s.CategoryID == categoryID)
                                .Where(s => s.SupplierID == supplierID).ToList();
                            return result;
                        }
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(searchString))
                        {
                            List<ProductViewModel> result = showedProductsNow.Where(s => s.CategoryID == categoryID)
                                .Where(s => s.Name.ToLower().Contains(searchString.ToLower())).ToList();

                            return result;
                        }
                        else
                        {
                            List<ProductViewModel> result = showedProductsNow.Where(s => s.CategoryID == categoryID).ToList();
                            return result;
                        }
                    }
                }
                else
                {
                    if (supplierID > 0)
                    {
                        if (!string.IsNullOrEmpty(searchString))
                        {
                            List<ProductViewModel> result = showedProductsNow
                                .Where(s => s.SupplierID == supplierID)
                                .Where(s => s.Name.ToLower().Contains(searchString.ToLower())).ToList();

                            return result;
                        }
                        else
                        {
                            List<ProductViewModel> result = showedProductsNow
                                .Where(s => s.SupplierID == supplierID).ToList();

                            return result;
                        }
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(searchString))
                        {
                            List<ProductViewModel> result = showedProductsNow
                                .Where(s => s.Name.ToLower().Contains(searchString.ToLower())).ToList();

                            return result;
                        }
                    }
                }
            }

            return showedProductsNow;
        }
    }
}
