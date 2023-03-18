using BestPracticesRESTAPI.Command;
using BestPracticesRESTAPI.MockDates.ProductCategoryMockDatas;
using BestPracticesRESTAPI.MockDates.ProductMockDates;
using BestPracticesRESTAPI.MockDates.ProductPictureMockDatas;
using BestPracticesRESTAPI.MockDates.ProductPriceMockDatas;
using BestPracticesRESTAPI.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace BestPracticesRESTAPI.Controllers.v1
{
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet("/api/v1/products")]
        public async Task<IActionResult> GetProductList()
        {
            List<ProductVM> productVMs = ProductMockDate.ProductVMsMockDate;

            return Ok(productVMs);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost("/api/v1/product")]
        public async Task<IActionResult> CreateProduct(CreateProductCommand command)
        {
            int productId = 1;//Product Id back from DataBase.

            return CreatedAtRoute(nameof(GetProduct), new { productId = productId }, new { ProductId = productId });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        [HttpGet("/api/v1/product/{productId:int}", Name = nameof(GetProduct))]
        public async Task<IActionResult> GetProduct(int productId)
        {
            ProductContentVM product = ProductMockDate.ProductContentVMMockDate;

            return Ok(product);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        [HttpPut("/api/v1/product/{productId:int}")]
        public async Task<IActionResult> UpdateProduct(int productId, UpdateProductCommand command)
        {
            if (productId != command.ProductId)
                return BadRequest("Bad Request Message");

            return NoContent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        [HttpDelete("/api/v1/product/{productId:int}")]
        public async Task<IActionResult> DeleteProduct(int productId)
        {
            return NoContent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost("/api/v1/product/{productId:int}/category")]
        public async Task<IActionResult> CreateProductCategory(int productId, CreateProductCategoryCommand command)
        {
            if (productId != command.ProductId)
                return BadRequest("Bad Request Message");

            return CreatedAtRoute(nameof(GetProductCategory), new { productId = productId }, new { ProductId = productId });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        [HttpGet("/api/v1/product/{productId:int}/category", Name = nameof(GetProductCategory))]
        public async Task<IActionResult> GetProductCategory(int productId)
        {
            ProductCategoryVM productCategoryVM = ProductCategoryMockData.ProductCategoryVMMokcData;

            return Ok(productCategoryVM);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPut("/api/v1/product/{productId:int}/category")]
        public async Task<IActionResult> UpdateProductCategory(int productId, UpdateProductCategoryCommand command)
        {
            if (productId != command.ProductId)
                return BadRequest("Bad Request Message");

            return NoContent();
        }

        [HttpDelete("/api/v1/product/{productId:int}/category")]
        public async Task<IActionResult> DeleteProductCategory(int productId)
        {
            return NoContent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPut("/api/v1/product/{productId:int}/picture")]
        public async Task<IActionResult> UpsertProductPicture(int productId, ProductPictureCommand command)
        {
            if (productId != command.ProductId)
                return BadRequest("Bad Request Message");

            return CreatedAtRoute(nameof(GetProductPicture), new { productId = productId }, new { ProductId = productId });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        [HttpGet("/api/v1/product/{productId:int}/picture", Name = nameof(GetProductPicture))]
        public async Task<IActionResult> GetProductPicture(int productId)
        {
            List<ProductPictureVM> productPictureVMs = ProductPictureMockData.ProductPictureVMs;

            return Ok(productPictureVMs);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost("/api/v1/product/{productId:int}/price")]
        public async Task<IActionResult> CreateProductPrice(int productId, CreateProductPriceCommand command)
        {
            if (productId != command.ProductId)
                return BadRequest("Bad Request Message");

            return CreatedAtRoute(nameof(GetProductPrice), new { productId = productId }, new { ProductId = productId });
        }

        [HttpGet("/api/v1/product/{productId:int}/price", Name = nameof(GetProductPrice))]
        public async Task<IActionResult> GetProductPrice(int productId)
        {
            ProductPriceVM productPriceVM = ProductPriceMockData.productPriceVMMockData;

            return Ok(productPriceVM);
        }

        [HttpPut("/api/v1/product/{productId:int}/price")]
        public async Task<IActionResult> UpdateProductPrice(int productId, UpdateProductPriceCommand command)
        {
            if (productId != command.ProductId)
                return BadRequest("Bad Request Message");

            return NoContent();
        }


    }
}
