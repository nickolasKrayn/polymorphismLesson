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
            Type = "Кукла";
        }
        public override void UnicPar()
        {
            Console.WriteLine("Материал: " + this.Material);
        }

    }
}
