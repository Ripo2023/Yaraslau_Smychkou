using MobileStore.MauiClient.Shared.Enums;

namespace MobileStore.MauiClient.Shared.RequestModels;

public class CreateOrderRequestModel
{
    public string Code { get; set; }

    public OrderStatus Status { get; set; }

    public IEnumerable<ProductComponentsRequestModel> Products { get; set; }
}
