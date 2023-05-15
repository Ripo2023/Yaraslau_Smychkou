using MobileStore.Gateway.Bll.Interfaces;
using MobileStore.Gateway.Common.RequestModels;
using MobileStore.Gateway.Common.ResponseModels;
using MobileStore.Gateway.Dal.Interfaces;

namespace MobileStore.Gateway.Bll.Services;

public class OrderService : IOrderService
{
    private readonly IOrderRepository orderRepository;

    public Task<int> CreateOrder(int userId, CreateOrderRequestModel model)
    {
        return orderRepository.CreateOrder(userId, model);
    }

    public Task<IEnumerable<OrderPreview>> GetAllOrders(int userId)
    {
        return orderRepository.GetAllOrders(userId);
    }

    public Task<OrderDetails> GetOrderDetails(int orderId)
    {
        return orderRepository.GetOrderDetails(orderId);
    }

    public Task UpdateOrder(UpdateOrderRequestModel model)
    {
        return orderRepository.UpdateOrder(model);
    }
}
