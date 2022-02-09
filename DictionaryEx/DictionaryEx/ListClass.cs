using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DictionaryEx
{
    class ListClass
    {
        public static void Main2(string[] args)
        {
            ArrayList list = new ArrayList();

            int total = 3;
            for (int i = 0; i < total; i++)
            {
                Console.WriteLine("Enter Name of Person and Age");
                string name = Console.ReadLine();
                int age = Convert.ToInt32(Console.ReadLine());
                list.Add(new Person()
                {
                    Naam = name,
                    Umar = age
                });
            }

            foreach (Person p in list)
            {
                Console.WriteLine(p.ToString());
            }
        }

        public class Person
        {
            public string Naam { get; set; }
            public int Umar { get; set; }


            public override string ToString()
            {
                return Naam + " - " + Umar;
            }
        }
    }
}
