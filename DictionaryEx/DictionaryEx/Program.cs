using System;
using System.Collections.Generic;

namespace DictionaryEx
{
    class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Grade Book Dictionary : ");
            Dictionary<string, string> IN = new Dictionary<string, string>();
            Console.WriteLine("Enter Student Id and Student Name : ");
            for (int i = 0; i < 3; i++)
            {
                IN.Add(Console.ReadLine(), Console.ReadLine());
            }
            foreach (var item in IN)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

        }
    }
}