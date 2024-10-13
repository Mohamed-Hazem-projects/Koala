using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Data.Models
{
    public class PaginatedList<T>
    {
        public List<T> Items { get; set; }
        public int TotalItems { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; private set; }

        public PaginatedList(List<T> items, int count, int pageIndex, int pageSize)
        {
            Items = items ?? new List<T>();
            TotalItems = count;
            PageIndex = pageIndex;
            PageSize = pageSize;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
        }

        public bool HasPreviousPage => (PageIndex > 1);
        public bool HasNextPage => (PageIndex < TotalPages);

        public int FirstItemIndex => (PageIndex - 1) * PageSize + 1;
        public int LastItemIndex => Math.Min(PageIndex * PageSize, TotalItems);

        public static async Task<PaginatedList<T>> CreateAsync(IQueryable<T> source, int pageIndex, int pageSize)
        {
            // Ensure pageIndex is at least 1
            if (pageIndex < 1) pageIndex = 1;

            var count = await source.CountAsync(); // Total number of items in the source data
            var items = await source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();

            return new PaginatedList<T>(items, count, pageIndex, pageSize);
        }
    }

}
