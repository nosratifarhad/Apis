namespace BestPracticesRESTAPI.Command
{
    public class CreateProductPriceOffCommand
    {
        public int ProductId { get; set; }

        public int PriceId { get; set; }

        public string PercentOff { get; set; }
        
    }
}
