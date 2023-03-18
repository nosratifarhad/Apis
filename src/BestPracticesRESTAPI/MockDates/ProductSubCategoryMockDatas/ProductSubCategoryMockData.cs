using BestPracticesRESTAPI.ViewModels;

namespace BestPracticesRESTAPI.MockDates.ProductSubCategoryMockDatas
{
    public static class ProductSubCategoryMockData
    {
        public static ProductSubCategoryVM ProductSubCategoryVM
            => new ProductSubCategoryVM()
            {
                ProductId = 1,
                CategoryId = 2,
                SubCategoryId = 10,
                Title = "موبایل"
            };
    }
}
