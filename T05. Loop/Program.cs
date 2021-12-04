using System;

namespace T05._Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int number = rnd.Next(1, 10);
            Console.WriteLine(number);
            int iterator = 0;

            while (iterator < 4)
            {
                int input = int.Parse(Console.ReadLine());
                iterator++;
                if (input == number)
                {
                    Console.WriteLine("You won");
                    break;
                }
            }
        }
    }
}
