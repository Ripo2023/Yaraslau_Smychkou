using MobileStore.MauiClient.Shared.RequestModels;
using MobileStore.MauiClient.Shared.ResponseModels;

namespace MobileStore.MauiClient.Bll.Interfaces;

public interface IOrderService
{
    Task<int> CreateOrder(int userId, CreateOrderRequestModel model);

    Task<OrderDetails> GetOrderDetails(int orderId);

    Task<IEnumerable<OrderPreview>> GetAllOrders(int userId);

    Task UpdateOrder(UpdateOrderRequestModel model);
}
