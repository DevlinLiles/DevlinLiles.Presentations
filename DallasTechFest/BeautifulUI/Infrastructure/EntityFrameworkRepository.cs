using System.Data.Entity;
using System.Linq;
using Core.Domain;
using Core.Interfaces;

namespace Infrastructure
{
    public class EntityFrameworkRepository : IRepository
    {
        private readonly DbContext _context;

        public EntityFrameworkRepository(DbContext context)
        {
            _context = context;
        }

        public T Get<T>(int id) where T : Entity
        {
            return _context.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<T> Find<T>() where T : Entity
        {
            return _context.Set<T>();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}