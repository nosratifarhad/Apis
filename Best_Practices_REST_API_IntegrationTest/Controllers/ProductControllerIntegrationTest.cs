using FluentAssertions;
using BestPracticesRESTAPI.ViewModels;
using System.Net;
using System.Text.Json;
using Best_Practices_REST_API_IntegrationTest.MockDates.CreateProductCommandMockDates;
using System.Net.Mime;
using System.Text;
using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Json;

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


        #region [ GetProductList ]

        [Fact]
        public async Task When_CallGetProductList_Then_ProductVMListShouldBeReturned()
        {
            var uri = "/api/v1/products";

            var response = await HttpClient.GetAsync(uri);

            response.IsSuccessStatusCode.Should().BeTrue();
            response.StatusCode.Should().Be(HttpStatusCode.OK);

            var jsonModel = await response.Content.ReadAsStringAsync();
            var responseModel = JsonSerializer.Deserialize<List<ProductContentVM>>(jsonModel);

            responseModel.Should().BeOfType<List<ProductContentVM>>();
            responseModel?.Should().NotBeNullOrEmpty();
            responseModel.Should().HaveCount(2);
        }


        #endregion [ GetProductList ]

        #region [ CreateProduct ]

        [Fact]
        public async Task When_ValidCreateProductCommandInCreateProduct_Then_ShouldBeCreated()
        {
            var uri = "/api/v1/product";

            var createProductCommand = CreateProductCommandMockDate.ValidCreateProductCommand;

            var request = CreateRequest(createProductCommand);

            var response = await HttpClient.PostAsync(uri, request);

            response.IsSuccessStatusCode.Should().BeTrue();
            response.StatusCode.Should().Be(HttpStatusCode.Created);
        }



        #endregion [ CreateProduct ]


        #region [ GetProduct ]

        [Fact]
        public async Task When_ValidProductIdInGetProduct_Then_ProductContentVMShouldBeReturned()
        {
            int productId = 1;

            var uri = $"/api/v1/product/{productId}";

            var response = await HttpClient.GetAsync(uri);

            response.IsSuccessStatusCode.Should().BeTrue();
            response.StatusCode.Should().Be(HttpStatusCode.OK);

            var jsonModel = await response.Content.ReadAsStringAsync();
            var responseModel = JsonSerializer.Deserialize<ProductContentVM>(jsonModel);

            responseModel.Should().BeOfType<ProductContentVM>();
            responseModel?.Should().NotBeNull();
        }


        #endregion [ GetProduct ]


        #region 
        protected HttpContent CreateRequest<T>(T model)
        {
            var option = new JsonSerializerOptions();

            var bodyStr = JsonSerializer.Serialize(model, option);

            var result = new StringContent(bodyStr, Encoding.UTF8, MediaTypeNames.Application.Json);

            return result;
        }

        #endregion
    }
}