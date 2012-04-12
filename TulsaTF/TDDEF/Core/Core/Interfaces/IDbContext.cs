using System.Data.Entity;
using System.Linq;

namespace Core.Interfaces
{
    public interface IDbContext
    {
        DbSet<T> Set<T>() where T : class;
        int SaveChanges();
    }
}