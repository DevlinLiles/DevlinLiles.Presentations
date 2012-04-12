using System.Linq;

namespace DataAccess
{
    public interface IUnitOfWork
    {
        IQueryable<T> Find<T>() where T : class;
        void Refresh();
        void Commit();
    }
}

