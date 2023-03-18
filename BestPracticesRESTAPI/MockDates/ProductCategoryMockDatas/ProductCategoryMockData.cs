using BestPracticesRESTAPI.ViewModels;

namespace BestPracticesRESTAPI.MockDates.ProductCategoryMockDatas
{
    public static class ProductCategoryMockData
    {
        public static ProductCategoryVM ProductCategoryVMMokcData
            => new ProductCategoryVM()
            {
                ProductId = 1,
                CategoryId = 10,
                Title = "گوشی موبایل"
            };
    }
}
