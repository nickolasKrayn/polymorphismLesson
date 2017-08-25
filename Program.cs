using System;
using SexShop.Products;

namespace SexShop
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Artem", "Улица Пушкина, дом Колотушкина", 100000, 550);

            Console.WriteLine("Список товаров:");

            Dolls gusDolls = new Dolls("Гусь", 200, "Гусыня", "резина", "Кукла");
            Condoms DirtyJoes = new Condoms("Грязный Джо", 400, "Хэнд Мейд", 25, "Контрацептив");
            Aphrodisiacs HorsesAphrodisiacs = new Aphrodisiacs("Конский возбудитель", 500, "Ферма Дяди Васи", "Любовь", "Афродизиак");
            Aphrodisiacs FriendAphrodisiacs = new Aphrodisiacs("Завали Подругу", 700, "Мачо Индастриз", "Клофелин, Спиртяга", "Афродизиак");
            AnalLube vasilin = new AnalLube("Вазилин", 500, "Вазилинодельня #1");

            Product[] products = new Product[] {
                gusDolls,
                DirtyJoes,
                HorsesAphrodisiacs,
                FriendAphrodisiacs,
                vasilin
            };

            foreach (var item in products)
            {
                Console.WriteLine(item.ToConsole(""));
            }

            Informer informer = new Informer();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine($"Здравствуйте {user.Name} ваш баланс {user.Balance}");

                for (int i = 0; i < products.Length; i++)
                {
                    Console.WriteLine($"Товар {i} {products[i].Name} по цене {products[i].Price}");
                }
                Console.WriteLine("Выберете номер товара и нажмите Enter:");

                string str = Console.ReadLine();
                int productNumber = Convert.ToInt32(str);

                if (productNumber >= 0 && productNumber < products.Length)
                {

                    if (products[productNumber].Price < user.Balance)
                    {
                        informer.Buy(user, products[productNumber]);
                    }
                    else
                    {
                        Console.WriteLine("У вас недостаточно средств");
                    }

                }
                else
                {
                    Console.WriteLine("Таких товаров нет");
                }
            }
        }
    }
}
