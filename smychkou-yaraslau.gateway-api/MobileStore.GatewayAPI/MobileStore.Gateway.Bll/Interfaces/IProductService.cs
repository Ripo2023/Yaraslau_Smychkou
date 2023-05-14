using MobileStore.Gateway.Common.ResponseModels;

namespace MobileStore.Gateway.Bll.Interfaces
{
    public interface IProductService
    {
        Task<ProductDetails> GetProductDetails(int productId);
    }
}
