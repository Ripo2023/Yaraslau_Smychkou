using MobileStore.MauiClient.Shared.Enums;

namespace MobileStore.MauiClient.Shared.RequestModels;

public class UpdateOrderRequestModel
{
    public int Id { get; set; }

    public string Code { get; set; }

    public OrderStatus Status { get; set; }

    public IEnumerable<ProductComponentsRequestModel> Products { get; set; }
}
