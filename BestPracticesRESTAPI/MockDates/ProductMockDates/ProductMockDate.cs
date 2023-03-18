using BestPracticesRESTAPI.ViewModels;

namespace BestPracticesRESTAPI.MockDates.ProductMockDates
{
    public static class ProductMockDate
    {
        public static ProductContentVM ProductContentVMMockDate
            => new ProductContentVM()
            {
                ProductId = 1,
                Title = "گوشی موبایل هوآوی مدل nova Y90 دو سیم کارت ظرفیت 128 گیگابایت و رم 8 گیگابایت",
                LatinName = "huawei",
                PersanName = "هوآوی",
                Description = @$"در بین گوشی‌های هوشمند سری nova شرکت هوآوی، شاهد رونمایی برخی از محصولاتی بودیم که در کنار بهره بردن از مشخصات فنی مناسب، قیمت مقرون به‌صرفه‌ای هم با خود به‌همراه داشته‌اند. هوآوی nova Y90 هم یکی از همین گوشی‌های هوشمند میان‌رده است که در نگاه اول سعی دارد تا خود را به‌عنوان یک گوشی بالا‌رده و پرچمدار معرفی کند. در نمای رو‌به‌رویی این گوشی به صفحه‌نمایش با ابعاد 6.7 اینچ و رزولوشن 1080×2388 پیکسل از نوع IPS که توانایی نمایش 391 پیکسل در هر اینچ را دارد مجهز شده است. صفحه‌نمای ...",
            };

        public static List<ProductVM> ProductVMsMockDate
            => new List<ProductVM>()
            {
                new()
                {
                    ProductId = 1,
                    Title = "گوشی موبایل هوآوی مدل nova Y90 دو سیم کارت ظرفیت 128 گیگابایت و رم 8 گیگابایت",
                    LatinName = "huawei",
                    PersanName = "هوآوی",
                    price = "10,699,000 "
                },
                new()
                {
                    ProductId = 2,
                    Title = "گوشی موبایل شیائومی مدل Redmi Note 11 NFC دو سیم‌ کارت ظرفیت 128 گیگابایت و رم 4 گیگابایت",
                    LatinName = "Redmi Note 11 NFC",
                    PersanName = "شیائومی",
                    price = "7,95,000"
                }

            };


    }
}
