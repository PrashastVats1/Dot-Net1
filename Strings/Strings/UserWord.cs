using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    class UserWord
    {
        static void Main3(string[] args)
        {
            string str = Console.ReadLine();
            string user = Console.ReadLine();
            string[] splits = str.Split(' ');
            foreach (string i in splits)
            {
                if (i == user)
                {
                    Console.WriteLine("Found substring {0} at word number {1}", user, Array.IndexOf(splits, i) + 1);
                }
            }
            Console.ReadLine();
        }
    }
}
