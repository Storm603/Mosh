using System;
using System.Collections.Generic;

namespace T06._Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> likeMenu = new List<string>();

            string name = Console.ReadLine();
            
            while (name != string.Empty)
            {
                likeMenu.Add(name);

                name = Console.ReadLine();
            }

            if (likeMenu.Count == 0)
            {
                Console.WriteLine("Display nothing");
            }
            else if (likeMenu.Count == 1)
            {
                Console.WriteLine(likeMenu[0] + " likes your post");
            }
            else if (likeMenu.Count == 2)
            {
                Console.WriteLine(likeMenu[0] + " and " + likeMenu[1] + " like your post");
            }
            else
            {
                Console.WriteLine(likeMenu[0] + " , " + likeMenu[1] + " and " + (likeMenu.Count - 2) + " others like your post");
            }
        }
    }
}
