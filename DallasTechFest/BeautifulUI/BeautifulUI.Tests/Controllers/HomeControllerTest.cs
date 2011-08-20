using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Core.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BeautifulUI;
using BeautifulUI.Controllers;
using Rhino.Mocks;

namespace BeautifulUI.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            var mockRepo = MockRepository.GenerateMock<IRepository>();
            HomeController controller = new HomeController(mockRepo);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.AreEqual("Welcome to ASP.NET MVC!", result.ViewBag.Message);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            var mockRepo = MockRepository.GenerateMock<IRepository>();
            HomeController controller = new HomeController(mockRepo);

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
