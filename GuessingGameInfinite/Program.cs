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
            //Количество попыток угадать число НЕ ОГРАНИЧЕНО
            //*случайное число генерируется только один раз (за пределами While цикла,
            //а внутри цикла пользователь может угадать это число)

            Random rand = new Random();
            int i = rand.Next(1, 11); //задуманное компьютером число
            int count = 1; count++; //n - номер попытки игрока, начиная с 1


            Console.WriteLine("Hi. What number did PC generate?");
            Console.WriteLine($"You have 3 attempts. Attempts {n}. Please input any number from 1 to 10: ");
            int u = Convert.ToInt32(Console.ReadLine()); //число, которое вводит игрок

            while (count <= 4)
            {

                if (i == u)
                {
                    Console.WriteLine($"Yes! You guessed! PC generated the number {u}!");
                    break;
                }

                else
                {
                    
                    if (count == 4)
                    {
                        Console.WriteLine($"Sorry, you didn't guess the number. It was {i}.");
                        break;

                    }

                    Console.WriteLine($"No, you didn't guess. Attempt {count}:");
                    u = Convert.ToInt32(Console.ReadLine());
                                                
                }
          
            }
            Console.WriteLine("If you want - play again!");
        }   
    }
}