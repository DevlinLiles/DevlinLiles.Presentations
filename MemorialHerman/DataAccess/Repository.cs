using System.Collections.Generic;

namespace DataAccess
{
    public class Repository : IRepository
    {
        private IDbContext _context;

        public Repository()
        {
            _context = new AdventureWorksContext();
        }

        public T Get<T>(ISingleObjectQuery<T> query) where T : class
        {
            return query.Execute(_context);
        }

        public IEnumerable<T> Find<T>(IQueryObject<T> query) where T : class
        {
            return query.Execute(_context);
        }
    }
}