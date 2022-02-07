using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace OopsConcepts2
{
    class RegexHandling
    {
        static void Main3(string[] args)
        {
            Console.Write("Enter input->");
            string a = Console.ReadLine();
            Regex re = new Regex("[0-9]{4}$");
            Match match = re.Match(a);
            if (match.Success)
            {
                Console.WriteLine("Success!! Ya aint an idiota !!");
            }
            else
            {
                Console.WriteLine("Input valid string idiota !!");
            }
        }
    }
}
