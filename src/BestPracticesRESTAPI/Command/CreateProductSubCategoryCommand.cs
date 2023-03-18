namespace BestPracticesRESTAPI.Command
{
    public class CreateProductSubCategoryCommand
    {
        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        public int SubCategoryId { get; set; }

        public string Title { get; set; }
    }
}
