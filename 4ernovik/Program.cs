using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //Игра "Угадай число"
            //Программа генерирует случайное число* от 1 до 10.
            //Программа предлагает пользователю угадать это число.
            //Пользователь пытается угадать это число
            //Если пользователь угадал число, программа поздравляет его с победой
            //Количество попыток угадать число НЕ ОГРАНИЧЕНО
            //*случайное число генерируется только один раз

            Random rand = new Random();
            int i = rand.Next(1, 11); //задуманное компьютером число
            int n = 1; //n - номер попытки игрока


            Console.WriteLine("Hi. What number did PC generate?");
            Console.WriteLine($"You have 3 attempts. Attempts {n}. Please input any number from 1 to 10: ");
            int u = Convert.ToInt32(Console.ReadLine()); //число, которое вводит игрок

            while (n > 0)
            {

                if (u == i)
                {
                    Console.WriteLine($"Yes! You guessed! PC generated the number {i}!");
                    break;
                }

                else
                    n++;
                {

                    Console.WriteLine($"No, you didn't guess. Attempt {n}:");
                    u = Convert.ToInt32(Console.ReadLine());

                }
            }
        }
    }
}