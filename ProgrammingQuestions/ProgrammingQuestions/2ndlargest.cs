using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingQuestions
{
    class _2ndlargest
    {
        static void Main5(string[] args)
        {
            int[] a = { 1, 3, 2, 5, 4, 8, 9, 10, 6, 7 };
            int n, i, j = 0, lrg, lrg2;
            lrg = 0;
            n = a.Length;
            for (i = 0; i < n; i++)
            {
                if (lrg < a[i])
                {
                    lrg = a[i];
                    j = i;
                }
            }
            lrg2 = 0;
            for (i = 0; i < n; i++)
            {
                if (i == j)
                {
                    i++;
                    i--;
                }
                else
                {
                    if (lrg2 < a[i])
                    {
                        lrg2 = a[i];
                    }
                }
            }

            Console.Write("The Second largest element in the array is :  " + lrg2);
        }
    }
}
