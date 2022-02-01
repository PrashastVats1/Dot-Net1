using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingQuestions
{
    class Matrixtranspose
    {
        static void Main6(string[] args)
        {
            int rows, cols;  
            int[,] a = {
                          {1, 2, 3},
                          {4, 5, 6},
                          {7, 8, 9}
                     };
            rows = a.GetLength(0);
            cols = a.GetLength(1); 
            int[,] t = new int[cols, rows]; 
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {  
                    t[i, j] = a[j, i];
                }
            }
            Console.WriteLine("Transpose of given matrix: ");
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(t[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
