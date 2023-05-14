using MobileStore.Gateway.Common.Enums;

namespace MobileStore.Gateway.Dal.Pocos;

public class OrderPreviewPoco
{
    public int Id { get; set; }

    public string Code { get; set; }

    public OrderStatus Status { get; set; }

    public int ProductId { get; set; }

    public string ProductName { get; set; }

    public string ProductImagePath { get; set; }
}
