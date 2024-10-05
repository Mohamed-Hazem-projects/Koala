using Inventory.Data.Context;
using Inventory.Repository.Interfaces;
using KoalaInventoryManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repository.Repositories
{
    public class ProductsRepository : GenericRepository<Product>, IProductsRepository
    {
        
        public ProductsRepository(InventoryDbContext context) : base(context)
        {
        }

        public IEnumerable<Product>? GetProductsBySupplier(int supplierId)
        {
            try
            {
                var products = _context.Products.Where(p => p.SupplierId == supplierId).ToList();
                return products;
            }
            catch (Exception ex)
            {
                //log error
                //.......

                return default;

            }
        }

        public IEnumerable<Product>? GetProductsByCategory(int CategoryId)
        {
            try
            {
                var products = _context.Products
                                      .Where(p => p.CategoryId == CategoryId)
                                      .ToList();
                return products;
            }
            catch (Exception ex)
            {
                //log error
                //.......

                return default;

            }
        }
    }
}
