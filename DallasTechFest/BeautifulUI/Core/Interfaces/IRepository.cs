using System.Linq;
using Core.Domain;

namespace Core.Interfaces
{
    public interface IRepository
    {
        T Get<T>(int id) where T : Entity;
        IQueryable<T> Find<T>() where T : Entity;
        void SaveChanges();
    }
}