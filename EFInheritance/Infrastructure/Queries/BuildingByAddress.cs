using System.Linq;
using Core.Entities;

namespace Infrastructure.Queries
{
    public class BuildingByAddress : FrameworkExtension.Core.QueryObjects.Query<Building>
    {
        public BuildingByAddress(string address)
        {
            ContextQuery = (c) => c.AsQueryable<Building>().Where(x => x.Address == address);
        }
    }
}