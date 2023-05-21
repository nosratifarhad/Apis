using BestPracticesRESTAPI.Command;
using BestPracticesRESTAPI.MockDates.ProductCategoryMockDatas;
using BestPracticesRESTAPI.MockDates.ProductMockDates;
using BestPracticesRESTAPI.MockDates.ProductPictureMockDatas;
using BestPracticesRESTAPI.MockDates.ProductPriceMockDatas;
using BestPracticesRESTAPI.MockDates.ProductSubCategoryMockDatas;
using BestPracticesRESTAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BestPracticesRESTAPI.Controllers.v1
{
    [ApiController]
    public class ProductController : ControllerBase
    {
        /// <summary>
        /// Get Product List
        /// </summary>
        /// <returns></returns>
        [HttpGet("/api/v1/products")]
        public async Task<IActionResult> GetProducts()
        {
            List<ProductVM> productVMs = ProductMockDate.ProductVMsMockDate;

            return Ok(productVMs);
        }

        /// <summary>
        /// Create Product
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost("/api/v1/products")]
        public async Task<IActionResult> CreateProduct(CreateProductCommand command)
        {
            int productId = 1;//Product Id back from DataBase.

            return CreatedAtRoute(nameof(GetProduct), new { productId = productId }, new { ProductId = productId });
        }

        /// <summary>
        /// Get Product
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        [HttpGet("/api/v1/products/{productId:int}", Name = nameof(GetProduct))]
        public async Task<IActionResult> GetProduct(int productId)
        {
            ProductContentVM product = ProductMockDate.ProductContentVMMockDate;

            return Ok(product);
        }

        /// <summary>
        /// Update Product
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPut("/api/v1/products/{productId:int}")]
        public async Task<IActionResult> UpdateProduct(int productId, UpdateProductCommand command)
        {
            if (productId != command.ProductId)
                return BadRequest("Bad Request Message");

            return NoContent();
        }

        /// <summary>
        /// Delete Product
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        [HttpDelete("/api/v1/products/{productId:int}")]
        public async Task<IActionResult> DeleteProduct(int productId)
        {
            return NoContent();
        }

        /// <summary>
        /// Upsert Product Picture
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPut("/api/v1/products/{productId:int}/picture")]
        public async Task<IActionResult> UpsertProductPicture(int productId, ProductPictureCommand command)
        {
            if (productId != command.ProductId)
                return BadRequest("Bad Request Message");

            return CreatedAtRoute(nameof(GetProductPicture), new { productId = productId }, new { ProductId = productId });
        }

        /// <summary>
        /// Get Product Picture
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        [HttpGet("/api/v1/products/{productId:int}/picture", Name = nameof(GetProductPicture))]
        public async Task<IActionResult> GetProductPicture(int productId)
        {
            List<ProductPictureVM> productPictureVMs = ProductPictureMockData.ProductPictureVMs;

            return Ok(productPictureVMs);
        }

        /// <summary>
        /// Create Product Price
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost("/api/v1/products/{productId:int}/price")]
        public async Task<IActionResult> CreateProductPrice(int productId, CreateProductPriceCommand command)
        {
            if (productId != command.ProductId)
                return BadRequest("Bad Request Message");

            return CreatedAtRoute(nameof(GetProductPrice), new { productId = productId }, new { ProductId = productId });
        }

        /// <summary>
        /// Get Product Price
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        [HttpGet("/api/v1/products/{productId:int}/price", Name = nameof(GetProductPrice))]
        public async Task<IActionResult> GetProductPrice(int productId)
        {
            ProductPriceVM productPriceVM = ProductPriceMockData.productPriceVMMockData;

            return Ok(productPriceVM);
        }

        /// <summary>
        /// Update Product Price
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPut("/api/v1/products/{productId:int}/price")]
        public async Task<IActionResult> UpdateProductPrice(int productId, UpdateProductPriceCommand command)
        {
            if (productId != command.ProductId)
                return BadRequest("Bad Request Message");

            return NoContent();
        }

        /// <summary>
        /// Delete Product Price
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        [HttpDelete("/api/v1/products/{productId:int}/price")]
        public async Task<IActionResult> DeleteProductPrice(int productId)
        {
            return NoContent();
        }

        /// <summary>
        /// Create Product Category
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost("/api/v1/products/{productId:int}/category")]
        public async Task<IActionResult> CreateProductCategory(int productId, CreateProductCategoryCommand command)
        {
            if (productId != command.ProductId)
                return BadRequest("Bad Request Message");

            return CreatedAtRoute(nameof(GetProductCategory), new { productId = productId }, new { ProductId = productId });
        }

        /// <summary>
        /// Get Product Category
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        [HttpGet("/api/v1/products/{productId:int}/category", Name = nameof(GetProductCategory))]
        public async Task<IActionResult> GetProductCategory(int productId)
        {
            ProductCategoryVM productCategoryVM = ProductCategoryMockData.ProductCategoryVMMokcData;

            return Ok(productCategoryVM);
        }

        /// <summary>
        /// Update Product Category
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPut("/api/v1/products/{productId:int}/category")]
        public async Task<IActionResult> UpdateProductCategory(int productId, UpdateProductCategoryCommand command)
        {
            if (productId != command.ProductId)
                return BadRequest("Bad Request Message");

            return NoContent();
        }

        /// <summary>
        /// Delete Product Category
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        [HttpDelete("/api/v1/products/{productId:int}/category")]
        public async Task<IActionResult> DeleteProductCategory(int productId)
        {
            return NoContent();
        }

        /// <summary>
        /// Create Product Sub Category
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="categoryId"></param>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost("/api/v1/products/{productId:int}/category/{categoryId:int}/subcategory")]
        public async Task<IActionResult> CreateProductSubCategory(int productId, int categoryId, CreateProductSubCategoryCommand command)
        {
            if (productId != command.ProductId ||
                categoryId != command.CategoryId)
                return BadRequest("Bad Request Message");

            return CreatedAtRoute(nameof(GetProductSubCategory),
                new { 
                    ProductId = productId, 
                    categoryId = command.CategoryId, 
                    subCategoryId = command.SubCategoryId 
                });
        }

        /// <summary>
        /// Get Product Sub Category
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="categoryId"></param>
        /// <param name="subCategoryId"></param>
        /// <returns></returns>
        [HttpGet("/api/v1/products/{productId:int}/category/{categoryId:int}/subcategory/{subCategoryId:int}", Name = nameof(GetProductSubCategory))]
        public async Task<IActionResult> GetProductSubCategory(int productId, int categoryId, int subCategoryId)
        {
            ProductSubCategoryVM productSubCategoryVM = ProductSubCategoryMockData.ProductSubCategoryVM;

            return Ok(productSubCategoryVM);
        }

        /// <summary>
        /// Update Product Sub Category
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="categoryId"></param>
        /// <param name="subCategoryId"></param>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPut("/api/v1/products/{productId:int}/category/{categoryId:int}/subcategory/{subCategoryId:int}")]
        public async Task<IActionResult> UpdateProductSubCategory(int productId, int categoryId, int subCategoryId, UpdateProductSubCategoryCommand command)
        {
            if (productId != command.ProductId ||
                categoryId != command.CategoryId ||
                subCategoryId != command.SubCategoryId)
                return BadRequest("Bad Request Message");

            return NoContent();
        }

        /// <summary>
        /// Delete Product Sub Category
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        [HttpDelete("/api/v1/products/{productId:int}/category/{categoryId:int}/subcategory/{subCategoryId:int}")]
        public async Task<IActionResult> DeleteProductSubCategory(int productId)
        {
            return NoContent();
        }


    }
}
