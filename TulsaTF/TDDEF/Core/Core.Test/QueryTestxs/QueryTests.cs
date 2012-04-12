using System.Collections.Generic;
using System.Linq;
using Core.Entities;
using Core.Queries;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.QueryTestxs
{
    [TestClass]
    public class QueryTests
    {
        [TestMethod]
        public void ShouldfilterByColor()
        {
            //Arrange
            var items = new List<Product>()
                            {
                                new Product() {Color = "Red"},
                                new Product() {Color = "Blue"}

                            }.AsQueryable();
            //Act
            var filteredItems = items.FilterByColor("Blue");

            //Assert
            Assert.AreEqual(1, filteredItems.Count());
            Assert.AreEqual("Blue",filteredItems.First().Color);
        }

        [TestMethod]
        public void ShouldGroupByColor()
        {
            //Arrange
            var items = new List<Product>()
                            {
                                new Product() {Color = "Red"},
                                new Product() {Color = "Red"},
                                new Product() {Color = "Blue"},
                                new Product() {Color = "Blue"},
                                new Product() {Color = "Blue"},
                                new Product() {Color = "Red"},
                                new Product() {Color = "Red"},
                                new Product() {Color = "Red"},
                                new Product() {Color = "Blue"},
                                new Product() {Color = "Blue"},
                                new Product() {Color = "Blue"}
                            }.AsQueryable();
            //Act
            var filteredItems = items.GroupByColor();

            //Assert
            Assert.AreEqual(5, filteredItems.Where(x=>x.Key == "Red").SelectMany(x=>x.Select(c=>c)).Count());
            Assert.AreEqual(6, filteredItems.Where(x => x.Key == "Blue").SelectMany(x => x.Select(c => c)).Count());
        }
    }
}