using System;

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

        public new void Display()
        {
            Console.WriteLine("Кукла:");
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Цена: " + Price);
            Console.WriteLine("Производитель: " + Manufacturer);
            Console.WriteLine("Материал: " + Material);
            Console.WriteLine(new String('-', 25));
        }
    }
}
