using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.DataTransfer
{
    public class DataTransferObject<T>
    {
        private IQueryable<T> query;

        internal IQueryable<T> Query
        {
            get { return query; }
            set { query = value; }
        }

        public IEnumerable<T> Result()
        {
            return query.AsEnumerable();
        }
    }
}