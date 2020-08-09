using EasyAuto.API;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EasyAuto.APITests.Support
{
    public class ApiWebApplicationFactory : WebApplicationFactory<Startup>
    {
        //protected override void ConfigureWebHost(IWebHostBuilder builder)
        //{
        //    //builder.ConfigureAppConfiguration(config =>
        //    //{
        //    //    var integrationConfig = new ConfigurationBuilder()
        //    //        .AddJsonFile("integrationsettings.json")
        //    //        .Build();

        //    //    config.AddConfiguration(integrationConfig);
        //    //});

        //    //builder.ConfigureTestServices(services =>
        //    //{
        //    //    services.AddTransient<IWeatherForecastConfigService, WeatherForecastConfigStub>();
        //    //});
        //}
    }

    //public interface IWeatherForecastConfigService
    //{
    //    public int NumberOfDays();
    //}

    //public class WeatherForecastConfigStub : IWeatherForecastConfigService
    //{
    //    public int NumberOfDays() => 7;
    //}

    //public class InvalidWeatherForecastConfigStub : IWeatherForecastConfigService
    //{
    //    public int NumberOfDays() => 7;
    //}

}
