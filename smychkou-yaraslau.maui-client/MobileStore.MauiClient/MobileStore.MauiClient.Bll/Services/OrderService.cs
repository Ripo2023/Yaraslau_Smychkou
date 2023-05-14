using MobileStore.MauiClient.Bff.Interfaces;
using MobileStore.MauiClient.Bll.Interfaces;
using MobileStore.MauiClient.Shared.RequestModels;
using MobileStore.MauiClient.Shared.ResponseModels;

namespace MobileStore.MauiClient.Bll.Services;

public class OrderService : IOrderService
{
    private readonly IOrderConnector orderConnector;

    public OrderService(IOrderConnector orderConnector)
    {
        this.orderConnector = orderConnector;
    }

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
