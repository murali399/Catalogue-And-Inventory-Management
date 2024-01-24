using catalogue.ApplicationLayer.Prodcuts.Query.GetProduct;
using catalogue.ApplicationLayer.Prodcuts.Query.GetProductByCategory;
using catalogue.ApplicationLayer.Prodcuts.Query.GetProductById;
using catalogue.ApplicationLayer.Prodcuts.Query.GetProductBySubCategory;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace CatalogueApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ApiControllerBase
    {
        private readonly ILogger<ProductController> logger;

        public ProductController(ILogger<ProductController> logger)
        {
            this.logger = logger;
        }
        [HttpGet("GetAllProduct")]
        public async Task<IActionResult> GetAll()
        {
            logger.LogInformation("GetAllProduct Action Method Was Invoked");
            var product = await Mediator.Send(new GetProductQuery());
            logger.LogInformation($"Finished GetAllProduct Request With Data:{JsonSerializer.Serialize(product)}");



            return Ok(product);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var blog = await Mediator.Send(new GetProdctByIdQuery { ProId = id });
            if (blog == null)
            {
                return NotFound();
            }
            return Ok(blog);
        }
        [HttpGet("GetProductByCategory")]
        public async Task<IActionResult> GetCategoryByProduc(string category)
        {
            var product = await Mediator.Send(new GetCategoryQuery{ cat=category});
            return Ok(product);
        }
        [HttpGet("GetProductBySubCategory")]
        public async Task<IActionResult> GetProductBySubCategory(string subcategory)
        {
            var product = await Mediator.Send(new GetSubCategoryquery{ sub = subcategory });
            return Ok(product);
        }




    }
}
