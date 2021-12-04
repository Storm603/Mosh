using System;
using System.Linq;

namespace T07._Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write 5 numbers on the console, each on a new row!");

            int[] numberCollection = new int[5];

            for (int i = 0; i < 5; i++)
            {
                int numberToAdd = int.Parse(Console.ReadLine());

                if (!numberCollection.Contains(numberToAdd))
                {
                    numberCollection[i] = numberToAdd;
                }
                else
                {
                    Console.WriteLine("The number exists, please insert a new number!");
                    i--;
                }
            }
            Array.Sort(numberCollection);

            Console.WriteLine("The collection consists of..");

            foreach (int number in numberCollection)
            {
                Console.WriteLine(number);
            }
        }
    }
}
