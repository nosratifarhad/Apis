namespace BestPracticesRESTAPI.Command
{
    public class UpdateProductCategoryCommand
    {
        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        public string Title { get; set; }

    }
}
