using System;

namespace T03._Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            int sum = 0;

            while (input != "ok")
            {
                int num = int.Parse(input);
                sum += num;
                input = Console.ReadLine();
            }

            Console.WriteLine(sum);
        }
    }
}
