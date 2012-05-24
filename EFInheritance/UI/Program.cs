using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrameworkExtension.Core.Repositories;
using Infrastructure;
using Infrastructure.Queries;
using UI.Properties;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new EntityFrameworkRepository(new ShopContext(Settings.Default.TestConnection));
            var items = repository.Find(new BuildingByAddress("One Hanover Way"));

            foreach (var product in items)
            {
                Console.WriteLine(product.Description);
            }

            Console.ReadLine();
        }
    }
}
