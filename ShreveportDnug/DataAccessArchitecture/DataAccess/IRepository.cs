using System;
using System.Linq;
using Infrastructure.DataTransfer;

namespace Infrastructure.Interfaces
{
    public interface IRepository
    {
        T Get<T>(Func<T, bool> where) where T : class;
        DataTransferObject<T> Find<T>() where T : class;
        void Add<T>(T item) where T : class;
        void Remove<T>(T item) where T : class;
        void Commit();
    }
}