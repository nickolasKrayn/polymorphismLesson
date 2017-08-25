namespace SexShop.Products
{
    class Dolls : Product
    {
        public string Material { get; private set; }

        public Dolls(string name, int price, string manufacturer, string material, string category)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            Material = material;
            Catgory = category;
        }

        public override string ToConsole(string s = "")
        {
            return base.ToConsole("Материал: " + Material);
        }
    }
}
