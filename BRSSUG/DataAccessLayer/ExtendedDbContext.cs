using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataAccessLayer
{
    public class ExtendedDbContext : DbContext, IDbContext
    {
        protected ExtendedDbContext(string connection) : base(connection)
        {
            
        }

        public IQueryable<T> AsQueryable<T>() where T : class
         {
             return this.Set<T>();
         }

        public IEnumerable<T> Find<T>(IQueryObject<T> query)
        {
            return query.Execute(this);
        }
    }

    public interface IQueryObject<T>
    {
        IEnumerable<T> Execute(IDbContext extendedDbContext);
    }

    public interface IDbContext
    {
        IQueryable<T> AsQueryable<T>() where T : class;
    }
}