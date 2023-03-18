namespace BestPracticesRESTAPI.Command
{
    public class ProductPictureCommand
    {
        public int ProductId { get; set; }

        public List<ProductPictureDetail> ProductPictureDetails { get; set; }
    }

    public class  ProductPictureDetail
    {

        public string Title { get; set; }

        public string PicturePatch { get; set; }
    }
}