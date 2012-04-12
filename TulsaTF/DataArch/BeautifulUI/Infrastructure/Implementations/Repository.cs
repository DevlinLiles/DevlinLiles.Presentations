using System.Data.Entity;
using System.Linq;
using Core.Interfaces;

namespace Infrastructure.Implementations
{
    public class Repository : IRepository
    {
        private readonly DbContext _context;

        public Repository(DbContext context)
        {
            _context = context;
        }

        public IQueryable<T> Find<T>()  where T : class
        {
            return _context.Set<T>();
        }

        public T Get<T>() where T : class
        {
            return _context.Set<T>().FirstOrDefault();
        }

        public void Add<T>(T item) where T : class
        {

        }

        public void Remove<T>(T item) where T : class
        {
            
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}