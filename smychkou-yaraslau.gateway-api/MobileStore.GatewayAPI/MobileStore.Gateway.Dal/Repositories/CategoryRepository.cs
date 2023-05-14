using Dapper;
using Microsoft.Extensions.Options;
using MobileStore.Gateway.Common.Configs;
using MobileStore.Gateway.Common.RequestModels;
using MobileStore.Gateway.Common.ResponseModels;
using MobileStore.Gateway.Dal.Constants;
using MobileStore.Gateway.Dal.Interfaces;
using MySql.Data.MySqlClient;

namespace MobileStore.Gateway.Dal.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DatabaseOptions options;

        public CategoryRepository(IOptions<DatabaseOptions> options)
        {
            this.options = options.Value;
        }

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            using var connection = new MySqlConnection(options.DefaultConnection);

            return await connection.QueryAsync<Category>(SqlQueries.GetAllCategories);
        }

        public async Task<IEnumerable<ProductPreview>> GetCategoryProductsByPage(GetCategoryProductsRequestModel model)
        {
            using var connection = new MySqlConnection(options.DefaultConnection);

            var queryParams = new
            {
                categoryId = model.CategoryId,
                lastViewedId = model.LastViewedId,
                pageSize = model.PageSize,
            };

            var query = model.LastViewedId is null
                ? SqlQueries.GetCategoryProductsByFirstPage
                : SqlQueries.GetCategoryProductsByPage;

            return await connection.QueryAsync<ProductPreview>(query, queryParams);
        }
    }
}
