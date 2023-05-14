namespace MobileStore.Gateway.Dal.Pocos
{
    internal class ProductDetailsPoco
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }

        public string StartPrice { get; set; }

        public int Number { get; set; }

        public int Volume { get; set; }

        public int ComponentId { get; set; }

        public string ComponentName { get; set; }

        public string ComponentImagePath { get; set; }

        public decimal ComponentPrice { get; set; }

        public bool ComponentIsStandart { get; set; }
    }
}
