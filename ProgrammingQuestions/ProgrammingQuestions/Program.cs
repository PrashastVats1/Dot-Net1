using System;

namespace ProgrammingQuestions
{
    class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Enter n till where to calculate");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1,s=0;
            for (i = 1; i < n + 1; i++)
            {
                s = s + i;
            }
            Console.WriteLine("Natural nos till n");
            for (i = 1; i < n + 1; i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine("Sum is " + s);
        }
    }
}
