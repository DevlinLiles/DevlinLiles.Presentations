using System.Data.Entity;
using System.Linq;
using Core.Interfaces;

namespace Infrastructure
{
    public class Repository : IRepository
    {
        private readonly IDbContext _dbContext;

        public Repository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<T> Find<T>() where T : class
        {
            return _dbContext.Set<T>();
        }

        public void Add<T>(T product) where T : class
        {
            _dbContext.Set<T>().Add(product);
        }

        public void Remove<T>(T product) where T : class
        {
            _dbContext.Set<T>().Remove(product);
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }
    }
}