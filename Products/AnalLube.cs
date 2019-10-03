using System;

namespace SexShop.Products
{
    class AnalLube : Product
    {
        public AnalLube(string name, int price, string manufacturer)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
        }

        public new void Display()
        {
            Console.WriteLine("Смазочка:");
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Цена: " + Price);
            Console.WriteLine("Производитель: " + Manufacturer);
            Console.WriteLine(new String('-', 25));
        }
    }
}
