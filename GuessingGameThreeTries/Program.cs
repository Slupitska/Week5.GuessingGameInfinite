using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //Игра "Угадай число"
            //Программа генерирует случайное число от 1 до 10.
            //Программа предлагает пользователю угадать это число.
            //Пользователь пытается угадать это число
            //Если пользователь угадал число, программа поздравляет его с победой
            //Количество попыток угадать число - 3.
            //*случайное число генерируется только один раз (за пределами While цикла,
            //а внутри цикла пользователь может угадать это число)

            Random rand = new Random();
            int i = rand.Next(1, 11); //задуманное компьютером число
            int n = 1; //n - номер попытки игрока


            Console.WriteLine("Hi. What number did PC generate?");
            Console.WriteLine($"You have 3 attempts. Attempts {n}. Please input any number from 1 to 10: ");
            int u = Convert.ToInt32(Console.ReadLine()); //число, которое вводит игрок

            while (n != 4)
            {

                if (u == i)
                {
                    Console.WriteLine($"Yes! You guessed! PC generated the number {i}!");
                    break;
                }

                else
                {
                    n++;
                    if (n == 4)
                    {
                        Console.WriteLine($"Sorry, you didn't guess the number. It was {i}");
                        Console.WriteLine("Play again if you want!");
                        break;
                    }
                }

                Console.WriteLine($"No, you didn't guess. Attempt {n}:");
                u = Convert.ToInt32(Console.ReadLine());



            }


        }
    }
}

