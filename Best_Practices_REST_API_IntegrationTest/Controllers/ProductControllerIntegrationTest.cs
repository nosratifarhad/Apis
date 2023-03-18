using FluentAssertions;
using BestPracticesRESTAPI.ViewModels;
using System.Net;
using System.Text.Json;

namespace Best_Practices_REST_API_IntegrationTest.Controllers
{
    public class ProductControllerIntegrationTest : IClassFixture<StartupFactory>
    {
        #region Fields
        protected HttpClient HttpClient;

        #endregion Fields

        #region Ctor

        public ProductControllerIntegrationTest(StartupFactory startupFactory)
        {
            HttpClient = startupFactory.CreateClient();
        }

        #endregion Ctor

        [Fact]
        public async Task When_CallGetProductList_Then_ProductVMListShouldBeReturned()
        {
            var uri = "/api/v1/products";

            var response = await HttpClient.GetAsync(uri);

            response.IsSuccessStatusCode.Should().BeTrue();
            response.StatusCode.Should().Be(HttpStatusCode.OK);

            var jsonModel = await response.Content.ReadAsStringAsync();
            var responseModel= JsonSerializer.Deserialize<List<ProductContentVM>>(jsonModel);

            responseModel.Should().BeOfType<List<ProductContentVM>>();
            responseModel?.Should().NotBeNullOrEmpty();
            responseModel.Should().HaveCount(2);
        }


    }
}