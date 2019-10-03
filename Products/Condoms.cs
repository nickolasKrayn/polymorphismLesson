using System;

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

        public new void Display()
        {
            Console.WriteLine("Контрацептив:");
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Цена: " + Price);
            Console.WriteLine("Производитель: " + Manufacturer);
            Console.WriteLine("Размер: " + Size);
            Console.WriteLine(new String('-', 25));
        }
    }
}
