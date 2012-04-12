using System.Linq;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IRepository
    {
        IQueryable<T> Find<T>() where T : class;
        void Add<T>(T product) where T : class;
        void Remove<T>(T product) where T : class;
        void Commit();
    }
}