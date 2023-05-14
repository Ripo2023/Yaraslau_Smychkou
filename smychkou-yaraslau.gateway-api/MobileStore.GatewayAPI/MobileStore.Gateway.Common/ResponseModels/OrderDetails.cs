using MobileStore.Gateway.Common.Enums;

namespace MobileStore.Gateway.Common.ResponseModels
{
    public class OrderDetails
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public OrderStatus Status { get; set; }

        public DateTime TakingDate { get; set; }

        public DateTime CompletedDate { get; set; }

        public IEnumerable<OrderProductInfo> Products { get; set; }
    }
}
