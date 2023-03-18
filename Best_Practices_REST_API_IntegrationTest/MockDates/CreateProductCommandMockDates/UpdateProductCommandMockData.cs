
using BestPracticesRESTAPI.Command;

namespace Best_Practices_REST_API_IntegrationTest.MockDates.CreateProductCommandMockDates
{
    public static class UpdateProductCommandMockData
    {
        public static UpdateProductCommand ValidUpdateProductCommand
            => new UpdateProductCommand()
            {
                ProductId = 1,
                Title = "Title"
            };
    }
}
