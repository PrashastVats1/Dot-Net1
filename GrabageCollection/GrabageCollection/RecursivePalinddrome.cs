using System;
using System.Collections.Generic;
using System.Text;

namespace GrabageCollection
{
    class RecursivePalinddrome
    {
        public static void Main4(string[] args)
        {
            Console.Write("Enter string to check for plaindrome->");
            string text = Console.ReadLine();
            //Console.WriteLine(IsPalindrome(text));
            if (IsPalindrome(text))
            {
                Console.WriteLine("String is a palindrome!");
            }
            else
            {
                Console.WriteLine("String is not a palindrome!");
            }
        }

        public static bool IsPalindrome(string text)
        {
            if (text.Length < 2)
            {
                return true;
            }
            else
            {
                if (text[0] != text[text.Length - 1])
                {
                    return false;
                }
                else
                {
                    return IsPalindrome(text.Substring(1, text.Length - 2));
                }
            }
        }
    }
}
