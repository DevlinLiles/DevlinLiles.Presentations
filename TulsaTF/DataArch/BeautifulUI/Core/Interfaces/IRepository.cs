using System;
using System.Linq;

namespace Core.Interfaces
{
    public interface IRepository
    {
        IQueryable<T> Find<T>() where T : class;
        T Get<T>() where T : class;
        void Add<T>(T item) where T : class;
        void Remove<T>(T item) where T : class;
        void Commit();
    }
}