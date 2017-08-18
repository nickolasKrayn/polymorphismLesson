namespace SexShop.Products
{
    class Aphrodisiacs : Product
    {
        public string Composition { get; set; }

        public Aphrodisiacs(string name, int price, string manufacturer, string composition)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            Composition = composition;
        }

        public override double GetDiscountPrice(User user)
        {
            return Price/2;
        }

    }
}
