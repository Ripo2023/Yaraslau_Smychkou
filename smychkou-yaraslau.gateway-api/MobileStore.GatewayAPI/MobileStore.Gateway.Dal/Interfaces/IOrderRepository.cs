using MobileStore.Gateway.Common.RequestModels;
using MobileStore.Gateway.Common.ResponseModels;

namespace MobileStore.Gateway.Dal.Interfaces
{
    public interface IOrderRepository
    {
        Task<int> CreateOrder(int userId, CreateOrderRequestModel model);

        Task<OrderDetails> GetOrderDetails(int orderId);

        Task<IEnumerable<OrderPreview>> GetAllOrders(int userId);

        Task UpdateOrder(UpdateOrderRequestModel model);
    }
}
