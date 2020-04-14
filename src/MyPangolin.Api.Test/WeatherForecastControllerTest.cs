using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MyPangolin.Api.Controllers;
using System.Linq;

namespace MyPangolin.Api.Test
{
    [TestClass]
    public class WeatherForecastControllerTest
    {
        [TestMethod]
        public void Get_OK_Count5()
        {
            var mockLogger = new Mock<ILogger<WeatherForecastController>>();
            var controller = new WeatherForecastController(mockLogger.Object);

            var result = controller.Get();

            Assert.AreEqual(5, result.Count());
        }
    }
}