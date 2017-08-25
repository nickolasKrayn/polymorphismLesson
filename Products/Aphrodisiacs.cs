namespace SexShop.Products
{
    class Aphrodisiacs : Product
    {
        public string Composition { get; set; }

        public Aphrodisiacs(string name, int price, string manufacturer, string composition, string category)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            Composition = composition;
            Catgory = category;
        }

        public override double GetDiscountPrice(User user)
        {
            return Price/2;
        }

        public override string ToConsole(string s = "")
        {
            return base.ToConsole("Состав: " + Composition);
        }
    }
}
