using System.Linq;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using Ordering.Controllers;

namespace Ordering.Tests
{
    public class WeatherForecastControllerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Get_Should_Return5Items()
        {
            var logger = new Mock<ILogger<WeatherForecastController>>();
            var controller = new WeatherForecastController(logger.Object);

            var result = controller.Get();

            Assert.That(result.Count() == 6);
        }
    }
}
