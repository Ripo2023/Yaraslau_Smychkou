using Dapper;
using Microsoft.Extensions.Options;
using MobileStore.Gateway.Common.Configs;
using MobileStore.Gateway.Common.ResponseModels;
using MobileStore.Gateway.Dal.Constants;
using MobileStore.Gateway.Dal.Interfaces;
using MobileStore.Gateway.Dal.Pocos;
using MySql.Data.MySqlClient;

namespace MobileStore.Gateway.Dal.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DatabaseOptions options;

        public ProductRepository(IOptions<DatabaseOptions> options)
        {
            this.options = options.Value;
        }

        public async Task<ProductDetails> GetProductDetails(int productId)
        {
            using var connection = new MySqlConnection(options.DefaultConnection);

            var queryParams = new
            {
                productId,
            };

            var pocos = await connection.QueryAsync<ProductDetailsPoco>(SqlQueries.GetProductDetails, queryParams);

            return pocos.GroupBy(poco => new
            {
                poco.Id,
                poco.Name,
                poco.Description,
                poco.ImagePath,
            }).Select(item => new ProductDetails
            {
                Id = item.Key.Id,
                Name = item.Key.Name,
                Description = item.Key.Description,
                ImagePath = item.Key.ImagePath,
                Components = item.GroupBy(poco => new
                {
                    Id = poco.ComponentId,
                    Name = poco.ComponentName,
                    ImagePath = poco.ComponentImagePath,
                    Price = poco.ComponentPrice,
                    IsStandart = poco.ComponentIsStandart,
                }).Select(item => new ProductComponentInfo
                {
                    Id = item.Key.Id,
                    Name = item.Key.Name,
                    ImagePath = item.Key.ImagePath,
                    Price = item.Key.Price,
                    IsStandart = item.Key.IsStandart,
                }).ToList(),
                Volumes = item.GroupBy(poco => new
                {
                    poco.Number,
                    poco.Volume,
                }).Select(item => new ProductVolumeInfo
                {
                    Number = item.Key.Number,
                    Volume = item.Key.Volume,
                }).ToList(),
            }).FirstOrDefault();
        }
    }
}
