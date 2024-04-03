using Microsoft.EntityFrameworkCore;

namespace RecordShop.Models.DataLayer
{
    public class Repository<T> : IRepository<T> where T : class
    {

        protected RecordShopContextModel context { get; set; }
        private DbSet<T> dbSet { get; set; }



        public Repository(RecordShopContextModel ctx)
        {
            context = ctx;
            dbSet = context.Set<T>();
        }




        public T? Get(int id) => dbSet.Find(id);



        public T? Get(QueryOptions<T> options)
        {
            IQueryable<T> query = dbSet;
            foreach (string include in options.GetIncludes())
            {
                query = query.Include(include);
            }
            if (options.HasWhere)
                query = query.Where(options.Where);
            return query.FirstOrDefault();
        }



        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }



        public IEnumerable<T> List(QueryOptions<T> options)
        {
            IQueryable<T> query = dbSet;
            foreach (string include in options.GetIncludes())
            {
                query = query.Include(include);
            }
            if (options.HasWhere)
                query = query.Where(options.Where);

            if (options.HasOrderBy)
            {
                if (options.HasThenOrderBy)
                {
                    query = query.OrderBy(options.OrderBy).ThenBy(options.ThenOrderBy);
                }
                else
                {
                    query = query.OrderBy(options.OrderBy);
                }
            }

            return query.ToList();
        }


        public void Update(T entity) => dbSet.Update(entity);

        public void Delete(T entity) => dbSet.Remove(entity);

        public void Save() => context.SaveChanges();

    }
}
