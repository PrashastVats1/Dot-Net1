﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace DictionaryEx
{
    class StackList
    {
        public static void Main8(string[] args)
        {
            Stack stack = new Stack();
            int total = 3;

            for (int i = 0; i < total; i++)
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());

                stack.Push(new Person()
                {
                    Name = name,
                    Age = age
                });
            }

            for (int i = 0; i < total; i++)
            {
                Person p = (Person)stack.Pop();
                Console.WriteLine(p.ToString());
            }
        }

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }


            public override string ToString()
            {
                return Name + " - " + Age;
            }
        }
    }
}
