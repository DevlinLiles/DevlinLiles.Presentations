using System.Data.Entity;
using System.Linq;
using Core.Interfaces;

namespace Infrastructure
{
    public class Context : DbContext, IDbContext
    {
    }
}