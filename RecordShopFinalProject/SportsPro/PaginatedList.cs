using Microsoft.EntityFrameworkCore;

namespace RecordShop
{
    public class PaginatedList<T> : List<T>
    {
        // Properties to hold current page index and total number of pages
        public int PageIndex { get; private set; }
        public int TotalPages { get; private set; }

        // Constructor to initialize PaginatedList with items, total count, page index, and page size
        public PaginatedList(List<T> items, int count, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize); // Calculate total pages by dividing total count by page size and rounding up


            this.AddRange(items); // Add provided items to the list
        }

        public bool HasPreviousPage => PageIndex > 1; // Property to check if there is a previous page
        public bool HasNextPage => PageIndex < TotalPages; // Property to check if there is a next page


        // Method to create a paginated list asynchronously from an IQueryable source
        public static async Task<PaginatedList<T>> CreateAsync(IQueryable<T> source, int pageIndex, int pageSize)
        {
            var count = await source.CountAsync(); // Count total number of items in the source asynchronously
            var items = await source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync(); // Retrieve items for the current page using Skip and Take operations

            // Return a new instance of PaginatedList with the retrieved items, total count, page index, and page size
            return new PaginatedList<T>(items, count, pageIndex, pageSize);
        }

    }
}
