using MobileStore.Gateway.Bll.Interfaces;
using MobileStore.Gateway.Common.ResponseModels;
using MobileStore.Gateway.Dal.Interfaces;

namespace MobileStore.Gateway.Bll.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public Task<ProductDetails> GetProductDetails(int productId)
        {
            return productRepository.GetProductDetails(productId);
        }
    }
}
