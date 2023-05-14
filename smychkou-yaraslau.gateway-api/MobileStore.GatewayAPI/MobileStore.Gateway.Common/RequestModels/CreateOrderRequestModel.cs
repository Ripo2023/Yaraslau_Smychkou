using MobileStore.Gateway.Common.Enums;

namespace MobileStore.Gateway.Common.RequestModels
{
    public class CreateOrderRequestModel
    {
        public string Code { get; set; }

        public OrderStatus Status { get; set; }

        public IEnumerable<ProductComponentsRequestModel> Products { get; set; }
    }
}
