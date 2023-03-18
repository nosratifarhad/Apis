using BestPracticesRESTAPI.Command;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BestPracticesRESTAPI.Controllers.v1
{
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet("/api/v1/products")]
        public async Task<IActionResult> GetProductList()
        {
            return Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost("/api/v1/product")]
        public async Task<IActionResult> CreateProduct(CreateProductCommand command)
        {
            return Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        [HttpGet("/api/v1/product/{productId:int}")]
        public async Task<IActionResult> GetProduct(int productId)
        {
            return Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        [HttpPut("/api/v1/product/{productId:int}")]
        public async Task<IActionResult> UpdateProduct(int productId)
        {
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
        public async Task<IActionResult> CreateProductCategory(int productId, ProductCategoryCommand command)
        {
            return NoContent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPut("/api/v1/product/{productId:int}/category")]
        public async Task<IActionResult> UpdateProductCategory(int productId, ProductCategoryCommand command)
        {
            return NoContent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        [HttpGet("/api/v1/product/{productId:int}/category")]
        public async Task<IActionResult> GetProductCategory(int productId)
        {
            return Ok();
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
            return NoContent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        [HttpGet("/api/v1/product/{productId:int}/picture")]
        public async Task<IActionResult> GetProductPicture(int productId)
        {
            return Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPut("/api/v1/product/{productId:int}/price")]
        public async Task<IActionResult> UpsertProductPrice(int productId, ProductPriceCommand command)
        {
            return NoContent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        [HttpGet("/api/v1/product/{productId:int}/price")]
        public async Task<IActionResult> GetProductPrice(int productId)
        {
            return Ok();
        }



    }
}
