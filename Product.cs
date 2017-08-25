using System;
using System.Text;

namespace SexShop
{
    class Product
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Catgory { get; set; }

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

        public override string ToString()
        {
            return Catgory;
        }

        public virtual string ToConsole(string s)
        {
            StringBuilder str = new StringBuilder();
            if (ToString() != null)
                str.AppendLine(ToString() + ":");
            str.AppendLine("Название: " + Name);
            str.AppendLine("Цена: " + Price);
            str.AppendLine("Производитель: " + Manufacturer);
            str.AppendLine(s);
            str.AppendLine(new String('-', 20));
            return str.ToString();
        }
    }
}
