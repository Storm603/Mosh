using System;
using System.Collections.Generic;

namespace T08._Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> collection = new List<int>();
            List<int> uniqueNums = new List<int>();

            string num = Console.ReadLine();

            while (num != "Quit")
            {
                int lett = int.Parse(num);

                collection.Add(lett);

                num = Console.ReadLine();
            }

            foreach (int number in collection)
            {
                int count = 0;

                for (int i = 0; i < collection.Count; i++)
                {
                    if (number == collection[i])
                    {
                        count++;
                    }
                }

                if (count == 1)
                {
                    uniqueNums.Add(number);
                }
            }

            foreach (int uniqueNum in uniqueNums)
            {
                Console.Write(uniqueNum + " ");
            }
        }
    }
}
