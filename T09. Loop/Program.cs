using System;
using System.Linq;

namespace T09._Loop
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(", ").ToArray();

            while (input.Length < 5)
            {
                Console.WriteLine("Invalid List");

                input = Console.ReadLine().Split(", ").ToArray();
            }
            Array.Sort(input);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(input[i]);
            }
        }
    }
}
