using System;
namespace SexShop
{
    class Product
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Type { get; protected set; }

        public virtual double GetDiscountPrice(User user)
        {
            if (user.Spent < 300)
            {
                return Price;
            }

            if (user.Spent < 1000)
            {
                return Price * 0.9;
            }

            return Price * 0.8;
        }

        public virtual void UnicPar() { }

        public void PrintInfo()
        {
            Console.WriteLine(this.Type + ": ");
            Console.WriteLine("Название: " + this.Name);
            Console.WriteLine("Цена: " + this.Price);
            Console.WriteLine("Производитель: " + this.Manufacturer);
            this.UnicPar();
            Console.WriteLine(new String('-', 25));
        }

    }
}
