using MobileStore.MauiClient.Shared.RequestModels;
using MobileStore.MauiClient.Shared.ResponseModels;

namespace MobileStore.MauiClient.Bff.Interfaces;

public interface ICategoryConnector
{
    Task<IEnumerable<Category>> GetAllCategories();

    Task<IEnumerable<ProductPreview>> GetCategoryProductsByPage(GetCategoryProductsRequestModel model);
}
