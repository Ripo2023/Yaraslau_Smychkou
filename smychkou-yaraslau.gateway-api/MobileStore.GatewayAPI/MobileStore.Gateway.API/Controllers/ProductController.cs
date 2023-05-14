using Microsoft.AspNetCore.Mvc;
using MobileStore.Gateway.Bll.Interfaces;
using System.Threading.Tasks;

namespace MobileStore.Gateway.API.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet("{productId}/details")]
        public async Task<IActionResult> GetProductDetails(int productId)
        {
            if (productId < 1)
            {
                return BadRequest();
            }

            var details = await productService.GetProductDetails(productId);

            if (details is null)
            {
                return NotFound();
            }

            return Ok(details);
        }
    }
}
