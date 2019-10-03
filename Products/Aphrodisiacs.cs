using System;

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

        public new void Display()
        {
            Console.WriteLine("Афродизиак:");
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Цена: " + Price);
            Console.WriteLine("Производитель: " + Manufacturer);
            Console.WriteLine("Состав: " + Composition);
            Console.WriteLine(new String('-', 25));
        }

        public override double GetDiscountPrice(User user)
        {
            return Price/2;
        }

    }
}
