using System.Linq.Expressions;

namespace RecordShop.Models.DataLayer
{
    public class QueryOptions<T>
    {

        // public properties for sorting and filtering

        public Expression<Func<T, Object>> OrderBy { get; set; } = null!;
        public Expression<Func<T, Object>> ThenOrderBy { get; set; } = null!;
        public Expression<Func<T, bool>> Where { get; set; } = null!;




        // Private String Array for include statements
        private string[] includes = Array.Empty<string>();

        // Public write-only property for include statments   - converts string to array
        public string Includes
        {
            set => includes = value.Replace(" ", "").Split(",");
        }





        // Private String Array for include statements
        public string[] GetIncludes() => includes;

        public bool HasWhere => Where != null;
        public bool HasOrderBy => OrderBy != null;
        public bool HasThenOrderBy => ThenOrderBy != null;

    }
}
