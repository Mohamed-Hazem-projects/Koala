using Inventory.Data.Context;
using Inventory.Repository.Interfaces;
using KoalaInventoryManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Inventory.Repository.Repositories
{
    public class WareHousesProductsRepository : IWareHousesProductsRepository
    {
        private readonly InventoryDbContext _context;
        public WareHousesProductsRepository(InventoryDbContext context)
            => _context = context;

        public IEnumerable<WareHouseProduct> GetAll()
        {
            try
            {
                List<WareHouseProduct> wareHousesPrds
                    = _context?.WareHousesProducts?.ToList() ?? new List<WareHouseProduct>();

                return wareHousesPrds;
            }
            catch (Exception ex)
            {
                //log error
                //.......

                return new List<WareHouseProduct>();
            }
        }

        /// <summary>
        /// Search with the product Id and gets the first occurence of it
        /// </summary>
        /// <param name="productID"></param>
        /// <returns></returns>
        public WareHouseProduct? GetbyId(int productID)
        {
            try
            {
                WareHouseProduct? productWareHouse
                    = _context?.WareHousesProducts?
                              .Include(whp => whp.WareHouse)
                              .FirstOrDefault(whp => whp.ProductID == productID);

                return productWareHouse;
            }
            catch (Exception ex)
            {
                //log error
                //.......

                return default;
            }
        }

        public IEnumerable<WareHouse>? GetProductWareHousesByPrdID(int productID)
        {
            try
            {
                List<WareHouse>? productWareHouses
                    = _context?.WareHousesProducts?
                              .Include(whp => whp.WareHouse)
                              .Where(whp => whp.ProductID == productID)
                              .Select(whp => whp.WareHouse)
                              .ToList();

                return productWareHouses;
            }
            catch (Exception ex)
            {
                //log error
                //.......

                return default;
            }
        }

        public IEnumerable<WareHouseProduct>? GettWareHousesProductsByPrdID(int productID, string[]? includes = null)
        {
            try
            {
                IQueryable<WareHouseProduct> query = _context.Set<WareHouseProduct>();

                if (includes != null)
                    foreach (var include in includes)
                        query = query.Include(include);

                List<WareHouseProduct>? wareHousesProducts = query.Where(whp => whp.ProductID == productID).ToList();

                return wareHousesProducts;
            }
            catch (Exception ex)
            {
                //log error
                //.......

                return default;
            }
        }

        public IEnumerable<Product>? GetWareHouseProductsByWHID(int wareHouseID)
        {
            try
            {
                List<Product>? wareHouseProducts
                    = _context?.WareHousesProducts?
                              .Include(whp => whp.Product)
                              .Where(whp => whp.WareHouseID == wareHouseID)
                              .Select(whp => whp.Product)
                              .ToList();

                return wareHouseProducts;
            }
            catch (Exception ex)
            {
                //log error
                //.......

                return default;
            }
        }

        public WareHouseProduct? GetWareHouseProduct(int productID, int wareHouseID)
        {
            try
            {
                return _context?.WareHousesProducts?.Find(productID, wareHouseID);
            }
            catch (Exception ex)
            {
                //log error
                //.......

                return default;
            }
        }

        public bool DeleteOneRecord(int productID, int WareHouseID)
        {
            try
            {
                WareHouseProduct? wareHousePrd
                    = _context?.WareHousesProducts?.Find(productID, WareHouseID);

                if (wareHousePrd != null)
                {
                    _context?.WareHousesProducts?.Remove(wareHousePrd);

                    if (_context?.Entry(wareHousePrd).State == EntityState.Deleted)
                        return true;
                    else
                        return false;
                }

                return false;
            }
            catch (Exception ex)
            {
                //log error
                //.......

                return false;
            }
        }

        public bool Add(WareHouseProduct entity)
        {
            try
            {
                _context?.WareHousesProducts?.Add(entity);

                if (_context?.Entry(entity).State == EntityState.Added)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                //log error
                //.......

                return false;
            }
        }

        public bool AddRange(ICollection<WareHouseProduct> entities)
        {
            try
            {
                _context.WareHousesProducts.AddRange(entities);
                if (_context?.Entry(entities)?.State == EntityState.Added)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                //log error
                //.......

                return false;
            }
        }

        public bool Update(WareHouseProduct entity)
        {
            try
            {
                WareHouseProduct? older
                    = _context?.WareHousesProducts?.Find(entity.ProductID, entity.WareHouseID);

                if (older != null)
                {
                    older.MinStock = entity.MinStock;
                    older.CurrentStock = entity.CurrentStock;
                    older.MaxStock = entity.MaxStock;
                    if (_context?.Entry(older)?.State == EntityState.Modified)
                        return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                //log error
                //.......

                return false;
            }
        }

        /// <summary>
        /// Deletes all records that match given ProductID
        /// </summary>
        /// <param name="productID"></param>
        /// <returns></returns>
        public bool Delete(int productID)
        {
            try
            {
                WareHouseProduct? existing = _context?.WareHousesProducts?.Find(productID);

                if (existing != null)
                {
                    _context?.WareHousesProducts?.Remove(existing);

                    if (_context?.Entry(existing).State == EntityState.Deleted)
                        return true;
                    else
                        return false;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                //log error
                //.......

                return false;
            }
        }

        public IEnumerable<WareHouseProduct> FindByName(Expression<Func<WareHouseProduct, bool>> match, string[]? includes = null)
        {
            try
            {
                IQueryable<WareHouseProduct> query = _context.Set<WareHouseProduct>();

                if (includes != null)
                    foreach (var include in includes)
                        query = query.Include(include);

                return query.Where(match).ToList();
            }
            catch (Exception ex)
            {
                //log error
                //.......

                return new List<WareHouseProduct>();
            }
        }

        public IEnumerable<WareHouseProduct> GetAll(string[] includes)
        {
            try
            {
                IQueryable<WareHouseProduct> query = _context.Set<WareHouseProduct>();

                if (includes != null && includes.Length > 0)
                    foreach (var include in includes)
                        query = query.Include(include);

                return query?.ToList() ?? new List<WareHouseProduct>();
            }
            catch (Exception ex)
            {
                //log error
                //.......

                return new List<WareHouseProduct>();
            }
        }

        public WareHouseProduct? GetbyId(int productID, string[] includes)
        {
            try
            {
                IQueryable<WareHouseProduct> query = _context.WareHousesProducts;

                if (includes != null && includes.Length > 0)
                {
                    foreach (string include in includes)
                        query = query.Include(include);
                }


                WareHouseProduct? productWareHouse 
                    = query.FirstOrDefault(whp => whp.ProductID == productID);

                return productWareHouse;
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
