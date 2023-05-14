using MobileStore.Gateway.Common.RequestModels;
using MobileStore.Gateway.Common.ResponseModels;

namespace MobileStore.Gateway.Bll.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllCategories();

        Task<IEnumerable<ProductPreview>> GetCategoryProductsByPage(GetCategoryProductsRequestModel model);
    }
}
