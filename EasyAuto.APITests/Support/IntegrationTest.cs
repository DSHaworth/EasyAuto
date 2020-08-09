using System.Net.Http;
using Microsoft.Extensions.Configuration;
using Xunit;

// https://timdeschryver.dev/blog/how-to-test-your-csharp-web-api
namespace EasyAuto.APITests.Support
{
    public abstract class IntegrationTest : IClassFixture<ApiWebApplicationFactory>
    {
        protected readonly ApiWebApplicationFactory _factory;
        protected readonly HttpClient _client;
        //protected readonly IConfiguration _configuration;

        public IntegrationTest(ApiWebApplicationFactory fixture)
        {
            _factory = fixture;
            _client = _factory.CreateClient();
            //_configuration = new ConfigurationBuilder()
            //    .AddJsonFile("Support/integrationsettings.json")
            //    .Build();
        }
    }
}