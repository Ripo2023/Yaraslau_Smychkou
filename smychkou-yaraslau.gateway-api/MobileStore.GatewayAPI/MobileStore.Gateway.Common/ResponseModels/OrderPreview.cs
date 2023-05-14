using MobileStore.Gateway.Common.Enums;

namespace MobileStore.Gateway.Common.ResponseModels
{
    public class OrderPreview
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public OrderStatus Status { get; set; } 

        public IEnumerable<ProductMark> Marks { get; set; }
    }
}
