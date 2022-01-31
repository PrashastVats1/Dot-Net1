using System;
using System.Collections.Generic;
using System.Text;

namespace OopsConcepts
{
    class leapyrcheck
    {
        static void main(string[] args)
        {
            Console.WriteLine("Input year");
            int yr = Convert.ToInt32(Console.ReadLine());
            if (yr % 4 == 0)
            {
                Console.WriteLine("Leap year");
            }
            else
            {
                Console.WriteLine("Not leap year");
            }
        }
    }
}
