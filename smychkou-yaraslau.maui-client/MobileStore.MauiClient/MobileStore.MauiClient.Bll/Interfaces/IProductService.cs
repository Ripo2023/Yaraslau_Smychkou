using MobileStore.MauiClient.Shared.ResponseModels;

namespace MobileStore.MauiClient.Bll.Interfaces;

public interface IProductService
{
    Task<ProductDetails> GetProductDetails(int productId);
}
