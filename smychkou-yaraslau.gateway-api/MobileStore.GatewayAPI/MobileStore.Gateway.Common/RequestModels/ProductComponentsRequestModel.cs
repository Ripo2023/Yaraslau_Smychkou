namespace MobileStore.Gateway.Common.RequestModels
{
    public class ProductComponentsRequestModel
    {
        public int ProductId { get; set; }

        public int VolumeNumber { get; set; }

        public IEnumerable<int> AdditionalComponents { get; set; }
    }
}
