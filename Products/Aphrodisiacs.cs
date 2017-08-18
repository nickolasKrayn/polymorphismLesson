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
            Type = "Афродизиак";
        }

        public override void UnicPar()
        {
            Console.WriteLine("Состав: " + this.Composition);
        }


        public override double GetDiscountPrice(User user)
        {
            return Price/2;
        }

    }
}
