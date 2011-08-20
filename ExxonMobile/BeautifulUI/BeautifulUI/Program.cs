using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using BeautifulUI.Entities;
using BeautifulUI.Properties;
using System.Data.Entity;

namespace BeautifulUI
{
    class Program
    {
        static void Main(string[] args)
        {
            AdventureWorksEntities entites = new AdventureWorksEntities();

            entites.CreateObjectSet<Employee>();

            AdventureWorksContext context = new AdventureWorksContext();
            var query = context.Set<Employee>().Include(x => x.Contact);
            ((ObjectQuery<Employee>) query).ToTraceString();
            foreach (var s in query)
            {
                Console.WriteLine(s.Contact.FirstName);
            }
        }
    }
}
