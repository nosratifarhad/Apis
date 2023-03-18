using BestPracticesRESTAPI.Command;
using BestPracticesRESTAPI.ViewModels;

namespace Best_Practices_REST_API_IntegrationTest.MockDates.CreateProductCommandMockDates
{
    public static class CreateProductCommandMockDate
    {
        public static CreateProductCommand ValidCreateProductCommand
            => new CreateProductCommand()
            {
                Title = "Title",
            };

    }
}
