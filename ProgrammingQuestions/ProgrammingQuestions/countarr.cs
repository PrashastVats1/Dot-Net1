using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingQuestions
{
    class countarr
    {
        static void Main4(string[] args)
        {
            int[] a = { 1, 2, 3, 3, 3, 2, 4 };
            int i,n,j,c=0;
            n = a.Length;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (a[i] == a[j])
                    {
                        c++;
                    }
                    
                }
                Console.WriteLine(a[i] + "comes" + c + "times");
                c = 0;
            }
        }
    }
}
