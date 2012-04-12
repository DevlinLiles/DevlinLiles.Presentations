using System.Linq;
using DataAccess.QueryObjects;
using BusinessLogic;


namespace DataAccess.Queries
{
     public class TitleNameQuery : QueryObject<Blog>
    {
        public TitleNameQuery(string title)
        {
            ContextQuery = (c) => c.AsQueryable<Blog>().Where(x => x.Title == title);
        }

    }
}