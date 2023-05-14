using MobileStore.MauiClient.Bff.Interfaces;
using MobileStore.MauiClient.Shared.RequestModels;
using MobileStore.MauiClient.Shared.ResponseModels;

namespace MobileStore.MauiClient.Bff.Connectors;

public class OrderConnector : IOrderConnector
{
    public Task<int> CreateOrder(int userId, CreateOrderRequestModel model)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<OrderPreview>> GetAllOrders(int userId)
    {
        throw new NotImplementedException();
    }

    public Task<OrderDetails> GetOrderDetails(int orderId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateOrder(UpdateOrderRequestModel model)
    {
        throw new NotImplementedException();
    }
}
