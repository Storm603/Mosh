using System;

namespace T01
{
    class Program
    {
        static void Main(string[] args)
        {
            int speedLimit = int.Parse(Console.ReadLine());

            int carSpeed = int.Parse(Console.ReadLine());

            if (carSpeed < speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                int count = 0;
                while (carSpeed > speedLimit)
                {
                    carSpeed -= 5;
                    count++;
                }

                if (count > 12)
                {
                    Console.WriteLine("License suspended");
                }
            }
        }
    }
}
