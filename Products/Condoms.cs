namespace SexShop.Products
{
    class Condoms : Product
    {
        public int Size { get; set; }

        public Condoms(string name, int price, string manufacturer, int size)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            Size = size;
        }
    }
}
