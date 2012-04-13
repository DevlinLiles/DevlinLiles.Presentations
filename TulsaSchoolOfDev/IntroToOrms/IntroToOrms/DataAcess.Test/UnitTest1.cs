using System;
using System.Linq.Expressions;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;
using DataAccess.Models;
using System.Data.Objects;
using System.Data.Entity.Infrastructure;

namespace DataAcess.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ProductCategory()
        {
            var context = new AdventureWorksContext("data source=localhost;database=AdventureWorks;integrated security=true");
            var query = context.Set<ProductCategory>()
                .Select(m => new { Id = m.ProductCategoryID } )
                .Where(m => m.Id == 1);
                //.OrderBy(m => m.ProductCategoryID)
                //.Take(10);
            Console.WriteLine(((DbQuery<ProductCategory>)query).ToString());
            foreach (var item in query)
            {
                Console.WriteLine(item.Id);
            }
        }
        [TestMethod]
        public void EF_CodeFirst_Example()
        {
            var context = new AdventureWorksContext("data source=localhost;database=AdventureWorks;integrated security=true");
            var query = context.Set<Product>()
                .OrderBy(m => m.ProductID)
                .Take(10);
            foreach (var item in query)
            {
                Console.WriteLine(item.ProductID);
            }
        }

        //[TestMethod]
        //public void EF_DataModel_Example()
        //{
        //    DataAccess.AdventureWorksEntities context = 
        //        new DataAccess.AdventureWorksEntities();
        //    IQueryable<DataAccess.Product> query = 
        //        context.Products
        //        .OrderBy(m => m.ProductID)
        //        .Take(10);
        //    foreach (var item in query)
        //    {
        //        Console.WriteLine(item.ProductID);
        //    }
        //}
       [TestMethod]
        public void ADO_Example()
        {
            string connString = "data source=localhost;integrated security=true";
            using (var conn = new SqlConnection(connString))
            {
                conn.Open();
                string sql = "SELECT top 10 * FROM adventureworks.production.PRODUCT";
                using (var comm = new SqlCommand(sql, conn))
                {
                    var dr = comm.ExecuteReader();
                    while (dr.Read())
                    {
                        Console.WriteLine(dr.GetInt32(0)); // DB Structure
                    }
                }
            }
        }
    }
}
