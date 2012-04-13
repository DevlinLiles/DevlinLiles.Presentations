//using System;
//using System.Collections.Generic;
//using System.Linq;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System.Data.SqlClient;
//using DataAccess.Models;

//namespace DataAcess.Test
//{
//    [TestClass]
//    public class UnitTest1
//    {
//        [TestMethod]
//        public void ProductCategory()
//        {
//            var context = new AdventureWorksContext("data source=localhost;database=AdventureWorks;integrated security=true");
//            var query = context.Set<ProductCategory>()
//                .Select(m => new { Id = m.ProductCategoryID } )
//                .Where(m => m.Id == 1);

//            foreach (var item in query)
//            {
//                Console.WriteLine(item.Id);
//            }
//        }

//        [TestMethod]
//        public void EF_CodeFirst_Example()
//        {
//            var context = new AdventureWorksContext("data source=localhost;database=AdventureWorks;integrated security=true");
//            var query = context.Set<Product>()
//                .OrderBy(m => m.ProductID)
//                .Take(10);
//            foreach (var item in query)
//            {
//                Console.WriteLine(item.ProductID);
//            }
//        }

//       [TestMethod]
//        public void ADO_Example()
//        {
//            string connString = "data source=localhost;integrated security=true";
//            using (var conn = new SqlConnection(connString))
//            {
//                conn.Open();
//                string sql = "SELECT top 10 * FROM adventureworks.production.PRODUCT";
//                using (var comm = new SqlCommand(sql, conn))
//                {
//                    var dr = comm.ExecuteReader();
//                    while (dr.Read())
//                    {
//                        Console.WriteLine(dr.GetInt32(0)); // DB Structure
//                    }
//                }
//            }
//        }
//    }
//}
