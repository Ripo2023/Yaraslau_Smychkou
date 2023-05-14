namespace MobileStore.Gateway.Common.ResponseModels
{
    public class ProductComponentInfo
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string ImagePath { get; set; }

        public bool IsStandart { get; set; }
    }
}
