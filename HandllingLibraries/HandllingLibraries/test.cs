﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HandllingLibraries
{
    class test
    {
        static void Main(string[] args) { byte varA = 10; byte varB = 20; long result = varA & varB; Console.WriteLine("{0} AND {1} Result :{2}", varA, varB, result); varA = 10; varB = 10; result = varA & varB; Console.WriteLine("{0} AND {1} Result : {2}", varA, varB, result); Console.ReadLine(); }
    }
}
