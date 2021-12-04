using System;

namespace T02._Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
