namespace ЕреминМихаил
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Доброе утро! Я ваш фитнес-бот. Готовы к тренировкам? (введите 'выход' для выхода)");

            while (true)
            {
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "выход")
                {
                    Console.WriteLine("Удачи! Не забывайте про активность!");
                    break;
                }

                string response = GenerateMotivation();
                Console.WriteLine(response);
            }
        }

        static string GenerateMotivation()
        {
            string[] motivations = {
                "Двигайтесь к своей цели, не останавливайтесь!",
                "Каждый день - это новый шанс стать лучше!",
                "Никогда не сдавайтесь, вы на правильном пути!",
                "Помните, маленькие шаги ведут к большим достижениям!"
            };

            Random rand = new Random();
            return motivations[rand.Next(motivations.Length)];
        }
    }
}