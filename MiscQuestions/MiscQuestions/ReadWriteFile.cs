using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MiscQuestions
{
    class ReadWriteFile
    {
        static void Main3(string[] args)
        {
            string path = "C:\\Users\\Prashast Vats\\OneDrive\\Desktop\\Capgemini Training\\file.txt";
            string Text = "Hello and welocem again to the GIJOESHOW! Yo!!!!";
            using (StreamWriter writetext = new StreamWriter(path))
            {
                writetext.WriteLine(Text);
            }
        }
    }
}
