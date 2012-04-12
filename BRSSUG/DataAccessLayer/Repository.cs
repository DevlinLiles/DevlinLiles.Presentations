using System.Collections.Generic;

namespace DataAccessLayer
{
    public class Repository: IRepository
    {
        private IDbContext _context;

        public Repository(IDbContext context)
        {
            _context = context;
        }

        public IEnumerable<T> Find<T>(IQueryObject<T> query) where T : class
        {
            query.Execute(_context);
        }
    }

    public interface IRepository
    {
        IEnumerable<T> Find<T>(IQueryObject<T> query) where T : class;

    }
}