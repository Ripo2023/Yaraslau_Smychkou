namespace MobileStore.Gateway.Common.ResponseModels
{
    public class OrderProductInfo
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ImagePath { get; set; }

        public int Volume { get; set; }

        public IEnumerable<string> AdditionalComponents { get; set; }

        public decimal Price { get; set; }
    }
}
