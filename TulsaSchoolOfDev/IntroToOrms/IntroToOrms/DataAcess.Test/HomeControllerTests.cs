using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Website.Controllers;
using System.Web.Mvc;
using Rhino.Mocks;

namespace DataAcess.Test
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void Index_Should_Return_To_The_View_A_List_Of_Products()
        {
            // Arrange
            var mockDataSvc = MockRepository
                .GenerateMock<IProductDataService>();
            mockDataSvc.Stub(m => m.GetProducts())
                .Return(new List<ProductViewModel>() { });
            var target = new HomeController(mockDataSvc);

            // Act
            var res = target.Index();

            // Assert
            Assert.IsInstanceOfType(res, typeof(ViewResult));
            var vr = res as ViewResult;
            Assert.IsInstanceOfType(vr.ViewData.Model, typeof(IndexViewModel));
        }
    }
}
