using Microsoft.AspNetCore.Mvc;
using MobileStore.Gateway.Bll.Interfaces;
using MobileStore.Gateway.Common.RequestModels;
using System.Threading.Tasks;

namespace MobileStore.Gateway.API.Controllers
{
    [ApiController]
    [Route("api/categories")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            return Ok(await categoryService.GetAllCategories());
        }

        [HttpGet("{categoryId}/products")]
        public async Task<IActionResult> GetCategoryProductsByPage([FromQuery] GetCategoryProductsRequestModel model)
        {
            return Ok(await categoryService.GetCategoryProductsByPage(model));
        }
    }
}
