using BestPracticesRESTAPI.ViewModels;

namespace BestPracticesRESTAPI.MockDates.ProductPriceOffMockDatas
{
    public class ProductPriceOffMockData
    {
        public static ProductPriceOffVM ProductPriceOffVM
            => new ProductPriceOffVM()
            {
                ProductId = 1,
                PriceId = 10,
                Price = "10,95,000",
                OffPrice = "7,95,000",
                PercentOff = "%11"
            };
    }
}
