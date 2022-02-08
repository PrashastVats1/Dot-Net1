using System;
using System.Collections.Generic;
using System.Text;

namespace GrabageCollection
{
    public class TempConverter
    {
        public static void Main2(string[] args)
        {
            Console.Write("Enter temperature in celsius");
            int cel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("kelvin= {0}", cel + 273);
            Console.WriteLine("fahrenheit= {0}", cel * 18 / 10 + 32);
        }
    }
}
