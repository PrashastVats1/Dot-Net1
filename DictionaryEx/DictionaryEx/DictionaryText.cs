using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryEx
{
    class DictionaryText
    {
        static void Main3(string[] args)
        {
            Console.WriteLine("Dictionary Text: ");
            Dictionary<string, int> IN = new Dictionary<string, int>();
            Console.WriteLine("Enter letters : ");
            for (int i = 0; i < 4; i++)
            {
                IN.Add(Console.ReadLine(),Convert.ToInt32(Console.ReadLine()));
            }
            foreach (var item in IN)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

        }
    }
}
