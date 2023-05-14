using MobileStore.Gateway.Bll.Interfaces;
using MobileStore.Gateway.Common.RequestModels;
using MobileStore.Gateway.Common.ResponseModels;
using MobileStore.Gateway.Dal.Interfaces;

namespace MobileStore.Gateway.Bll.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public Task<IEnumerable<Category>> GetAllCategories()
        {
            return categoryRepository.GetAllCategories();
        }

        public Task<IEnumerable<ProductPreview>> GetCategoryProductsByPage(GetCategoryProductsRequestModel model)
        {
            return categoryRepository.GetCategoryProductsByPage(model);
        }
    }
}
