using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController weatherForecastController = new WeatherForecastController(null);

        [Fact]
        public void WeatherForecastController_GET_Returns5Results()
        {
            int expectedValue = 5;
            IEnumerable<WeatherForecast> result = weatherForecastController.Get();
            Assert.Equal(expectedValue, result.Count());
        }

        [Fact]
        public void WeatherForecastController_GET_Returns10Results()
        {
            int expectedValue = 10;
            IEnumerable<WeatherForecast> result = weatherForecastController.Get();
            Assert.Equal(expectedValue, result.Count());
        }
    }
}
