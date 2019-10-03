using System;

namespace SexShop
{
    class Product
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }

        public void Display(){}

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
    }
}
