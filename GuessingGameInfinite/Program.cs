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
            
            Console.WriteLine("Hi. What number did PC generate?");
            Console.WriteLine($"You have unlimited attempts. Please input any number from 1 to 10: ");
                        
            bool loopActive = true;
            while (loopActive)
            {
                int u = Convert.ToInt32(Console.ReadLine()); //число, которое вводит игрок

                if (u == i)
                {
                    Console.WriteLine($"You guessed! PC generated the number {u}!");
                    loopActive = false;
                }
                else
                {
                    Console.WriteLine("Sorry, you didn't guess the number. Try again !");

                }
            }
            Console.WriteLine("If you want - play again!");
        }
    }
}