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
        throw new NotImplementedException();
    }
}
