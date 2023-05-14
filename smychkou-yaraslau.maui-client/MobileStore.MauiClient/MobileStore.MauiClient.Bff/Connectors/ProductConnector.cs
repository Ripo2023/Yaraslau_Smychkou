using MobileStore.MauiClient.Bff.Interfaces;
using MobileStore.MauiClient.Shared.ResponseModels;

namespace MobileStore.MauiClient.Bff.Connectors;

public class ProductConnector : IProductConnector
{
    public Task<ProductDetails> GetProductDetails(int productId)
    {
        throw new NotImplementedException();
    }
}
