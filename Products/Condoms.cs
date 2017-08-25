namespace SexShop.Products
{
    class Condoms : Product
    {
        public int Size { get; set; }

        public Condoms(string name, int price, string manufacturer, int size, string category)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            Size = size;
            Catgory = category;
        }

        public override string ToConsole(string s = "")
        {
            return base.ToConsole("Размер: " + Size);
        }
    }
}
