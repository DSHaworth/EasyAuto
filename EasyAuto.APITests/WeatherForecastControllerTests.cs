using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using EasyAuto.API;
using EasyAuto.APITests.Support;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Xunit;

namespace EasyAuto.APITests
{
    public class WeatherForecastControllerTests : IntegrationTest
    {

        public WeatherForecastControllerTests(ApiWebApplicationFactory fixture)
            : base(fixture) { }

        [Fact]
        public async Task Get_Should_Retrieve_Forecast()
        {
            var response = await _client.GetAsync("/weatherforecast");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            // or
            response.StatusCode.Should().Be(HttpStatusCode.OK);

            var forecast = JsonConvert.DeserializeObject<WeatherForecast[]>(await response.Content.ReadAsStringAsync());
            forecast.Should().HaveCount(5);
        }

        [Fact]
        public async Task Get_Should_BadRequest()
        {
            var response = await _client.GetAsync("/notfound");

            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        //[Fact]
        //public async Task Get_Should_ResultInABadRequest_When_ConfigIsInvalid()
        //{
        //    var client = _factory.WithWebHostBuilder(builder =>
        //        {
        //            builder.ConfigureServices(services =>
        //            {
        //                services.AddTransient<IWeatherForecastConfigService, InvalidWeatherForecastConfigStub>();
        //            });
        //        })
        //        .CreateClient(new WebApplicationFactoryClientOptions());

        //    var response = await client.GetAsync("/weatherforecast");
        //    response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        //}

    }
}
