using MobileStore.MauiClient.Shared.Enums;

namespace MobileStore.MauiClient.Shared.ResponseModels;

public class OrderPreview
{
    public int Id { get; set; }

    public string Code { get; set; }

    public OrderStatus Status { get; set; }

    public IEnumerable<ProductMark> Marks { get; set; }
}
