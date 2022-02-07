using System;
using System.Collections.Generic;
using System.Text;

namespace ClassnStructures
{
    class ConstVsReadOnly
    {
        public readonly int number1;
        public const int number2 = 4;
        public ConstVsReadOnly(int a)
        {
            number1 = a;
            Console.WriteLine("Value of number is {0}, {1}", number1, number2);
        }
        public static void Main2()
        {
            ConstVsReadOnly Obj = new ConstVsReadOnly(3);
            Console.WriteLine();
        }
    }
}