using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DictionaryEx
{
    class UpperStringList
    {
        static void Main4(string[] args)
        {
            List<string> mylist = test(new List<string>(new string[] { "Abc", "cdef", "js", "php" }));
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }
        }
        public static List<string> test(List<string> str)
        {
            IEnumerable<string> s = str.Select(x => x.ToUpper());
            return s.ToList();
        }
    }
}
