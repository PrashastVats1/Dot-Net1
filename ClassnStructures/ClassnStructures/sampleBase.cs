using System;
using System.Collections.Generic;
using System.Text;

namespace ClassnStructures
{
    public static class sampleBase
    {
        public static void Method(this Class1 ob)
        {
            Console.WriteLine("Hello I am a extended Method");
        }
    }
}
