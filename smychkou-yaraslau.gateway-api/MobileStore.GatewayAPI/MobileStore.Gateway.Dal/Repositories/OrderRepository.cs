using Microsoft.Extensions.Options;
using MobileStore.Gateway.Common.Configs;
using MobileStore.Gateway.Common.RequestModels;
using MobileStore.Gateway.Common.ResponseModels;
using MobileStore.Gateway.Dal.Interfaces;
using MySql.Data.MySqlClient;

namespace MobileStore.Gateway.Dal.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DatabaseOptions options;

        public OrderRepository(IOptions<DatabaseOptions> options)
        {
            this.options = options.Value;
        }

        public Task<int> CreateOrder(int userId, CreateOrderRequestModel model)
        {
            using var connection = new MySqlConnection(options.DefaultConnection);

            var queryParams = new
            {
                code = model.Code,
                status = model.Status,
                userId,
            };

            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrderPreview>> GetAllOrders(int userId)
        {
            using var connection = new MySqlConnection(options.DefaultConnection);

            throw new NotImplementedException();
        }

        public Task<OrderDetails> GetOrderDetails(int orderId)
        {
            using var connection = new MySqlConnection(options.DefaultConnection);

            throw new NotImplementedException();
        }

        public Task UpdateOrder(UpdateOrderRequestModel model)
        {
            using var connection = new MySqlConnection(options.DefaultConnection);

            throw new NotImplementedException();
        }
    }
}
