namespace BestPracticesRESTAPI.Command
{
    public class UpdateProductPriceOffCommand
    {
        public int ProductId { get; set; }

        public int PriceId { get; set; }

        public string PercentOff { get; set; }

    }
}
