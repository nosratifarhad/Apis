namespace BestPracticesRESTAPI.ViewModels
{
    public class ProductPriceOffVM
    {
        public int ProductId { get; set; }

        public int PriceId { get; set; }

        public string Price { get; set; }

        public string OffPrice { get; set; }
        
        public string PercentOff { get; set; }
        
    }
}
