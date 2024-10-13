namespace Inventory.Data.Shared
{
    public class PaginatedList<T> : List<T>
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public int PageNumbers { get; set; }

        public int TotalItems { get; set; }
        public int ItemsCountPerPage { get; set; }
        public PaginatedList(List<T> items, int count, int pageNumber, int actualCount)
        {
            PageIndex = pageNumber;
            TotalItems = count;
            PageNumbers = (int)Math.Ceiling(count / (double)10);
            ItemsCountPerPage = actualCount;
            this.AddRange(items);
        }
        public bool HasPreviousPage => PageIndex > 1;
        public bool HasNextPage => PageIndex < PageNumbers;

        public static PaginatedList<T> GetPaginatedList(IQueryable<T> source, int pageNumber)
        {
            var count = source.Count();
            var items = source.Skip((pageNumber - 1) * 10).Take(10).ToList();
            var actualCount = items.Count;
            return new PaginatedList<T>(items, count, pageNumber, actualCount);
        }
    }
}
