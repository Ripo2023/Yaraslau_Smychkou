using MobileStore.Gateway.Common.RequestModels;
using MobileStore.Gateway.Common.ResponseModels;

namespace MobileStore.Gateway.Dal.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllCategories();

        Task<IEnumerable<ProductPreview>> GetCategoryProductsByPage(GetCategoryProductsRequestModel model);
    }
}
