using MobileStore.MauiClient.Bff.Interfaces;
using MobileStore.MauiClient.Shared.RequestModels;
using MobileStore.MauiClient.Shared.ResponseModels;

namespace MobileStore.MauiClient.Bff.Connectors;

public class CategoryConnector : ICategoryConnector
{
    public Task<IEnumerable<Category>> GetAllCategories()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ProductPreview>> GetCategoryProductsByPage(GetCategoryProductsRequestModel model)
    {
        throw new NotImplementedException();
    }
}
