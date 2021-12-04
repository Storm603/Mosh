using System;

namespace T04._Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int facNum = int.Parse(Console.ReadLine());

            int sum = 0;
            int currNum = 1;

            for (int i = facNum; i >= 1; i--)
            {
                sum = currNum * i;
                currNum = sum;
            }

            Console.WriteLine($"{facNum}! = {sum}");
        }
    }
}
