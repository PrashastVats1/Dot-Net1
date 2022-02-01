using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingQuestions
{
    class Factorial
    {
        static void Main3(string[] args)
        {
            Console.WriteLine("Enter no whose factorial is to be calculated");
            int n = Convert.ToInt32(Console.ReadLine());
            int i, p = 1;
            for (i = 1; i < n + 1; i++)
            {
                p = p * i;
            }
            Console.WriteLine("Factorial is " + p);
        }
    }
}
