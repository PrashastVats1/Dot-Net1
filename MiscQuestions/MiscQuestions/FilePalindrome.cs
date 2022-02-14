using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MiscQuestions
{
    class FilePalindrome
    {
        static void Main4(string[] args)
        {
            Console.WriteLine(" Enter string");
            string path = "C:\\Users\\Prashast Vats\\OneDrive\\Desktop\\Capgemini Training\\file.txt";
            string Text = Console.ReadLine();
            using (StreamWriter writetext = new StreamWriter(path))
            {
                writetext.WriteLine(Text);
            }
            string text = File.ReadAllText(@"C:\\Users\\Prashast Vats\\OneDrive\\Desktop\\Capgemini Training\\file.txt", Encoding.UTF8);
            //Console.WriteLine(text);
            string s = text.Trim();
            string revs = "";
            for (int i = s.Length - 1; i >= 0; i--) //String Reverse  
            {
                revs += s[i].ToString();
            }
            if (revs == s) // Checking whether string is palindrome or not  
            {
                Console.WriteLine("String is Palindrome \n Entered String Was {0} and reverse string is {1}", s, revs);
            }
            else
            {
                Console.WriteLine("String is not Palindrome \n Entered String Was {0} and reverse string is {1}", s, revs);
            }
        }
    }
}
