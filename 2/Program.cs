class Program
{
    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("Выберите программу:");
            Console.WriteLine("1. Игра 'Угадай число'");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("0. Выйти");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Play1();
                    break;
                case 2:
                    Play2();
                    break;
                case 3:
                    Play3();
                    break;
                case 0:
                    Console.WriteLine("Программа завершена.");
                    break;
                default:
                    Console.WriteLine("Некорректный выбор. Пожалуйста, введите снова.");
                    break;
            }
        } while (choice != 0);
    }

    static void Play1()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 101);
        int attempts = 0;
        int guess;

        Console.WriteLine("Добро пожаловать в игру 'Угадай число'!");
        do
        {
            Console.Write("Введите число: ");
            guess = int.Parse(Console.ReadLine());
            attempts++;

            if (guess < randomNumber)
                Console.WriteLine("Загаданное число больше.");
            else if (guess > randomNumber)
                Console.WriteLine("Загаданное число меньше.");
            else
                Console.WriteLine($"Поздравляем! Вы угадали число {randomNumber} за {attempts} попыток.");
        } while (guess != randomNumber);
    }

    static void Play2()
    {
        Console.WriteLine("Таблица умножения:");
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{i * j,4}");
            }
            Console.WriteLine();
        }
    }

    static void Play3()
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine($"Делители числа {number}:");
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
                Console.WriteLine(i);
        }
    }
}
