namespace Модуль_12
{
    internal class Program
    {
        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
        static void Main(string[] args)
        {
            var user1 = new User("Roman", "Роман", true);
            var user2 = new User("Ivan", "Иван", false);

            Console.WriteLine("Введите логин пользователя:");

            var user = Console.ReadLine();

            if (user == user1.Login)
            {
                Console.WriteLine($"Добрый день, {user1.Name}!");

                if (user1.IsPremium == false)
                {
                    ShowAds();
                }
            }

            if (user == user2.Login)
            {
                Console.WriteLine($"Добрый день, {user2.Name}!");

                if (user2.IsPremium == false)
                {
                    ShowAds();
                }
            }
        }
    }

    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }

        public User(string login, string name, bool isPremium)
        {
            Login = login;
            Name = name;
            IsPremium = isPremium;
        }
    }
}
