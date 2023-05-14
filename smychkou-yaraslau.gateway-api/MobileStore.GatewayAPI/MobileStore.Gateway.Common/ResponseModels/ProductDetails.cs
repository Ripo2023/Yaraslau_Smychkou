namespace MobileStore.Gateway.Common.ResponseModels
{
    public class ProductDetails
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }

        public IEnumerable<ProductVolumeInfo> Volumes { get; set; }

        public IEnumerable<ProductComponentInfo> Components { get; set; }
    }
}
