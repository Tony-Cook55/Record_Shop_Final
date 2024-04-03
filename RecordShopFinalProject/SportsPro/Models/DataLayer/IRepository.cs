namespace RecordShop.Models.DataLayer
{
        public interface IRepository<T> where T : class
        {
            IEnumerable<T> List(QueryOptions<T> options);

            //Get Type By Id
            T? Get(int id);


            // Get type with LINQ Query
            T? Get(QueryOptions<T> options);


            // CREATE
            void Insert(T entity);

            // UPDATE
            void Update(T entity);

            // DELETE
            void Delete(T entity);

            // SAVE
            void Save();

        }
}
