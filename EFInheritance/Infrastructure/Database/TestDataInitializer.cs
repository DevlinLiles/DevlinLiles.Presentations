using System.Collections.Generic;
using System.Data.Entity;
using Core.Entities;

namespace Infrastructure.Database
{
    public class TestDataInitializer : DropCreateDatabaseAlways<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {
            var floors = new List<Floor>
                             {
                                 new Floor
                                     {
                                         FloorNumber = 1
                                     }
                             };

            var buildings = new List<Building>
                                {
                                    new Building()
                                        {
                                            Address = "One Hanover Park", 
                                            Floors = floors
                                        },
                                    new Building()
                                        {
                                            Address = "Test Building"
                                        }
                                };

            context.Add(new Project()
                            {
                                Code = "Test",
                                ProjectName = "Test Project",
                                Buildings = buildings

                            });
        }
    }
}