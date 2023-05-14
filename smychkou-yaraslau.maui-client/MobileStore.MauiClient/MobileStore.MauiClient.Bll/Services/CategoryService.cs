using MobileStore.MauiClient.Bff.Interfaces;
using MobileStore.MauiClient.Bll.Interfaces;
using MobileStore.MauiClient.Shared.RequestModels;
using MobileStore.MauiClient.Shared.ResponseModels;

namespace MobileStore.MauiClient.Bll.Services;

public class CategoryService : ICategoryService
{
    private readonly ICategoryConnector categoryConnector;

    public CategoryService(ICategoryConnector categoryConnector)
    {
        this.categoryConnector = categoryConnector;
    }

    public Task<IEnumerable<Category>> GetAllCategories()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ProductPreview>> GetCategoryProductsByPage(GetCategoryProductsRequestModel model)
    {
        throw new NotImplementedException();
    }
}
