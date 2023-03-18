using BestPracticesRESTAPI.ViewModels;

namespace BestPracticesRESTAPI.MockDates.ProductPriceMockDatas
{
    public static class ProductPriceMockData
    {
        public static ProductPriceVM productPriceVMMockData
            => new ProductPriceVM()
            {
                ProductId = 1,
                Price = "7,95,000"
            };
    }
}
