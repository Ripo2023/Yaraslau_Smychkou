using MobileStore.MauiClient.Bff.Interfaces;
using MobileStore.MauiClient.Bll.Interfaces;
using MobileStore.MauiClient.Shared.ResponseModels;

namespace MobileStore.MauiClient.Bll.Services;

public class ProductService : IProductService
{
    private readonly IProductConnector productConnector;

    public ProductService(IProductConnector productConnector)
    {
        this.productConnector = productConnector;
    }

    public Task<ProductDetails> GetProductDetails(int productId)
    {
        return Task.FromResult(new ProductDetails
        {
            Id = 1,
            Name = "Cappucino",
            Description = "Espresso based coffee with the addition of warmed foamed milk",
            ImagePath = "ImagePath",
            StartCost = 120,
            Volumes = new[]
            {
                new ProductVolumeInfo
                {
                    Number = 1,
                    Volume = 200,
                },
                new ProductVolumeInfo
                {
                    Number = 2,
                    Volume = 300,
                },
                new ProductVolumeInfo
                {
                    Number = 3,
                    Volume = 400,
                },
            },
            Components = new[]
            {
                new ProductComponentInfo
                {
                    Id = 1,
                    Name = "Espresso arabica",
                    IsStandart = true,
                    ImagePath = "ImagePath",
                    Price = 80,
                },
                new ProductComponentInfo
                {
                    Id = 2,
                    Name = "Cows milk",
                    IsStandart = true,
                    ImagePath = "ImagePath",
                    Price = 40,
                },
                new ProductComponentInfo
                {
                    Id = 2,
                    Name = "Without syrop",
                    IsStandart = false,
                    ImagePath = "ImagePath",
                    Price = 40,
                },
            }
        });
    }
}
