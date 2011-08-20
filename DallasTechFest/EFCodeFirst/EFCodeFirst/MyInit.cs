using System.Data.Entity;
using EFCodeFirst.Repository;

namespace EFCodeFirst
{
    public class MyInit : DropCreateDatabaseAlways<AdventureWorksContext>
    {
         
    }
}