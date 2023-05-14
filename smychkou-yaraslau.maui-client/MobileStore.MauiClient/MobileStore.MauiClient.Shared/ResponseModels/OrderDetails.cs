using MobileStore.MauiClient.Shared.Enums;

namespace MobileStore.MauiClient.Shared.ResponseModels;

public class OrderDetails
{
    public int Id { get; set; }

    public string Code { get; set; }

    public OrderStatus Status { get; set; }

    public IEnumerable<OrderProductInfo> Products { get; set; }
}
