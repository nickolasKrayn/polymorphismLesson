namespace SexShop.Products
{
    class Dolls : Product
    {
        public string Material { get; private set; }

        public Dolls(string name, int price, string manufacturer, string material)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            Material = material;
        }
    }
}
