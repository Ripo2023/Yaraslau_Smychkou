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
        //return categoryConnector.GetAllCategories();

        return Task.FromResult(new[]
        {
            new Category
            {
                Id = 1,
                Name = "Coffee",
            },
            new Category
            {
                Id = 2,
                Name = "Tea",
            },
            new Category
            {
                Id = 3,
                Name = "Drinks",
            },
            new Category
            {
                Id = 4,
                Name = "Deserts",
            },
        }.AsEnumerable());
    }

    public Task<IEnumerable<ProductPreview>> GetCategoryProductsByPage(GetCategoryProductsRequestModel model)
    {
        return Task.FromResult(new[]
        {
            new ProductPreview
            {
                Id = 1,
                Name = "Cappucino",
                ImagePath = "ImagePath",
                StartPrice = 120,
            },
            new ProductPreview
            {
                Id = 2,
                Name = "Espresso",
                ImagePath = "ImagePath",
                StartPrice = 120,
            },
            new ProductPreview
            {
                Id = 3,
                Name = "Latte",
                ImagePath = "ImagePath",
                StartPrice = 120,
            },
            new ProductPreview
            {
                Id = 4,
                Name = "Raff",
                ImagePath = "ImagePath",
                StartPrice = 120,
            },
        }.AsEnumerable());
    }
}
