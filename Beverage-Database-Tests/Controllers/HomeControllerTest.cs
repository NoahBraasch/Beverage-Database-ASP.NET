using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Beverage_Database.Controllers;

namespace cis237_assignment_6_tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            var mockLogger = new Mock<ILogger<HomeController>>();
            HomeController controller = new HomeController(mockLogger.Object);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Privacy()
        {
            // Arrange
            var mockLogger = new Mock<ILogger<HomeController>>();
            HomeController controller = new HomeController(mockLogger.Object);

            // Act
            ViewResult result = controller.Privacy() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
