using MobileStore.Gateway.Common.ResponseModels;

namespace MobileStore.Gateway.Dal.Interfaces
{
    public interface IProductRepository
    {
        Task<ProductDetails> GetProductDetails(int productId);
    }
}
