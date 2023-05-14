using MobileStore.MauiClient.Shared.ResponseModels;

namespace MobileStore.MauiClient.Bff.Interfaces;

public interface IProductConnector
{
    Task<ProductDetails> GetProductDetails(int productId);
}
