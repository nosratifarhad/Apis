using BestPracticesRESTAPI.ViewModels;

namespace BestPracticesRESTAPI.MockDates.ProductPictureMockDatas
{
    public static class ProductPictureMockData
    {
        public static List<ProductPictureVM> ProductPictureVMs
            => new List<ProductPictureVM>()
            {
                new ProductPictureVM()
                {
                    ProductId = 1,
                    Title = "گوشی موبایل شیائومی مدل Redmi Note 11S دو سیم کارت ظرفیت 128 گیگابایت و رم 8 گیگابایت - گلوبال",
                    PicturePatch = "https://dkstatics-public.digikala.com/digikala-products/e61958991d5905572f1a5385af53ef57376a0cb6_1656406171.jpg?x-oss-process=image/resize,m_lfit,h_800,w_800/quality,q_90",
                },
                new ProductPictureVM()
                {
                    ProductId = 1,
                    Title = "گوشی موبایل شیائومی مدل Redmi Note 11S دو سیم کارت ظرفیت 128 گیگابایت و رم 8 گیگابایت - گلوبال",
                    PicturePatch = "https://dkstatics-public.digikala.com/digikala-products/3ce0aa52062f1e0734025f44260be5fefc295fef_1655549372.jpg?x-oss-process=image/resize,m_lfit,h_800,w_800/quality,q_90",
                }

            };


    }
}
