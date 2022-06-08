using Ardalis.HttpClientTestExtensions;
using Floriess_WebApp.Web;
using Floriess_WebApp.Web.ApiModels;
using Xunit;

namespace Floriess_WebApp.FunctionalTests.ControllerApis
{
    [Collection("Sequential")]
    public class ProjectCreate : IClassFixture<CustomWebApplicationFactory<WebMarker>>
    {
        private readonly HttpClient _client;

        public ProjectCreate(CustomWebApplicationFactory<WebMarker> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task ReturnsOneProject()
        {
            var result = await _client.GetAndDeserialize<IEnumerable<ProjectDTO>>("/api/projects");

            Assert.Single(result);
            Assert.Contains(result, i => i.Name == SeedData.TestProject1.Name);
        }
    }
}