using System.Collections.Generic;
using System.Threading.Tasks;
using Moq;
using MyWeather.Models;
using MyWeather.Services;
using MyWeather.ViewModels;
using NUnit.Framework;

namespace MyWeather.Tests.nUnit
{
    [TestFixture()]
    public class WeatherViewModelTest
    {
        [Test()]
        public void Constructor_Should_Not_Fail()
        {
            // arrange

            // act
            var vm = new WeatherViewModel();

            // assert
            Assert.AreEqual(true, vm.IsImperial, "Default measure is Imperial");
            Assert.AreEqual("Seattle,WA", vm.Location, "Default location is Seattle, WA");
        }

        [Test()]
        public void ExecuteGetWeatherCommand_Should_Get_Proper_Weather()
        {
            // arrange
            var vm = new WeatherViewModel();
            var mockWeatherService = new Mock<WeatherService>();
            mockWeatherService
                .Setup(x => x.GetWeather(It.IsAny<string>(), Units.Imperial))
                .Returns(Task.FromResult(new WeatherRoot { CityId = 0, Weather = new List<Weather> { new Weather { Description = "Fake Description"}} }));

            mockWeatherService
                .Setup(x => x.GetForecast(It.IsAny<int>(), Units.Imperial))
                .Returns(Task.FromResult(new WeatherForecastRoot { City= new City { Name = "Seattle"} }));

            vm.WeatherService = mockWeatherService.Object;

            // act
            vm.GetWeatherCommand.Execute(null);

            // assert
            Assert.AreEqual(true, vm.IsImperial, "Default measure is Imperial");
            Assert.AreEqual("Seattle,WA", vm.Location, "Default location is Seattle, WA");
            Assert.AreNotEqual("Unable to get Weather", vm.Temp, "Should resolve temperature");
        }
    }
}
