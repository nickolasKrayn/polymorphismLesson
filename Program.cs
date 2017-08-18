using System;
using SexShop.Products;

namespace SexShop
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User(
                "Artem",
                "Улица Пушкина, дом Колотушкина",
                100000,
                550
                );

            Console.WriteLine("Список товаров:");

            Dolls gusDolls = new Dolls(
                "Гусь",
                200,
                "Гусыня",
                "резина"
                );

            Console.WriteLine("Кукла:");
            Console.WriteLine("Название: " + gusDolls.Name);
            Console.WriteLine("Цена: " + gusDolls.Price);
            Console.WriteLine("Производитель: " + gusDolls.Manufacturer);
            Console.WriteLine("Материал: " + gusDolls.Material);
            Console.WriteLine(new String('-', 25));

            Condoms DirtyJoes = new Condoms(
                "Грязный Джо",
                400,
                "Хэнд Мейд",
                25
                );

            Console.WriteLine("Контрацептив:");
            Console.WriteLine("Название: " + DirtyJoes.Name);
            Console.WriteLine("Цена: " + DirtyJoes.Price);
            Console.WriteLine("Производитель: " + DirtyJoes.Manufacturer);
            Console.WriteLine("Размер: " + DirtyJoes.Size);
            Console.WriteLine(new String('-', 25));

            Aphrodisiacs HorsesAphrodisiacs = new Aphrodisiacs(
                "Конский возбудитель",
                500,
                "Ферма Дяди Васи",
                "Любовь"
                );

            Console.WriteLine("Афродизиак:");
            Console.WriteLine("Название: " + HorsesAphrodisiacs.Name);
            Console.WriteLine("Цена: " + HorsesAphrodisiacs.Price);
            Console.WriteLine("Производитель: " + HorsesAphrodisiacs.Manufacturer);
            Console.WriteLine("Состав: " + HorsesAphrodisiacs.Composition);
            Console.WriteLine(new String('-', 25));

            Aphrodisiacs FriendAphrodisiacs = new Aphrodisiacs("Завали Подругу",
                700,
                "Мачо Индастриз",
                "Клофелин, Спиртяга"
                );

            Console.WriteLine("Афродизиак:");
            Console.WriteLine("Название: " + FriendAphrodisiacs.Name);
            Console.WriteLine("Цена: " + FriendAphrodisiacs.Price);
            Console.WriteLine("Производитель: " + FriendAphrodisiacs.Manufacturer);
            Console.WriteLine("Состав: " + FriendAphrodisiacs.Composition);
            Console.WriteLine(new String('-', 25));

            AnalLube vasilin = new AnalLube(
                "Вазилин",
                500,
                "Вазилинодельня #1"
                );

            Console.WriteLine("Афродизиак:");
            Console.WriteLine("Название: " + vasilin.Name);
            Console.WriteLine("Цена: " + vasilin.Price);
            Console.WriteLine("Производитель: " + vasilin.Manufacturer);
            Console.WriteLine(new String('-', 25));


            Product[] products = new Product[] {
                gusDolls,
                DirtyJoes,
                HorsesAphrodisiacs,
                FriendAphrodisiacs,
                vasilin
            };

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
