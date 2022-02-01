using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingQuestions
{
    class Pattern
    {
        static void Main2(string[] args)
        {
            int c=1,i,j;
            for (i = 1; i < 5; i++)
            {
                for (j = 1; j < i+1; j++)
                {
                    Console.Write(c);
                    c++;
                }
                Console.WriteLine("");
            }
        }
    }
}
