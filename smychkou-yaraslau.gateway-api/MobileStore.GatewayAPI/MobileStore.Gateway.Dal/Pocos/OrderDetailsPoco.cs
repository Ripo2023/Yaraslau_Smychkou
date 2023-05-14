using MobileStore.Gateway.Common.Enums;

namespace MobileStore.Gateway.Dal.Pocos;

internal class OrderDetailsPoco
{
    public int Id { get; set; }

    public string Code { get; set; }

    public OrderStatus Status { get; set; }

    public DateTime TakingDate { get; set; }

    public DateTime CompletedDate { get; set; }

    public int ProductId { get; set; }

    public string ProductName { get; set; }

    public string ProductImagePath { get; set; }

    public int ProductVolume { get; set; }

    public string ProductAdditionalComponentName { get; set; }

    public decimal ProductPrice { get; set; }
}
