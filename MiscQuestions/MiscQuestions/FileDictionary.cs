using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;

namespace MiscQuestions
{
    class FileDictionary
    {
        static string val;
        static string key;

        static Dictionary<string, string> dict = new Dictionary<string, string>();
        static void Main5(string[] args)
        {
            string path = "C:\\Users\\Prashast Vats\\OneDrive\\Desktop\\Capgemini Training\\file.txt";
            string Text = Console.ReadLine();
            using (StreamWriter writetext = new StreamWriter(path))
            {
                writetext.WriteLine(Text);
            }
            string[] allLines = File.ReadAllLines(@"C:\\Users\\Prashast Vats\\OneDrive\\Desktop\\Capgemini Training\\file.txt");
            string[] wordbits = allLines;
            for (int i = 0; i < wordbits.Length - 1; i += 2)
            {
                key = wordbits[i];
                val = wordbits[(i + 1)];
                dict.Add(key, val);
            }
                Console.WriteLine("you typed in "+ wordbits);
        }
    }
}
