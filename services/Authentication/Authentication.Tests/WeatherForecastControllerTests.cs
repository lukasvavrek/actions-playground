using System.Linq;
using Authentication.Controllers;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;

namespace Authentication.Tests
{
    public class WeatherForecastControllerTests
    {
        [Test]
        public void Get_Should_Return5Items()
        {
            var logger = new Mock<ILogger<WeatherForecastController>>();
            var controller = new WeatherForecastController(logger.Object);

            var result = controller.Get();

            Assert.That(result.Count() == 5);
        }
    }
}
