using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class AbstractClassProblem
    {
        public static void Main2(string[] args)
        {
            Dog dog = new Dog();
            Console.Write("What is the doggy's name?");
            dog.SetName(Console.ReadLine());
            Console.Write("The doggo's name is->");
            Console.WriteLine(dog.GetName());
            dog.Eat();
        }

        public class Dog : Animal
        {
            public override void Eat()
            {
                Console.WriteLine("The doggo likes eating whatever the heck I want to feed him cuz he is stoopid like that!");
            }
        }

        public abstract class Animal
        {
            private string Name;

            public void SetName(string name)
            {
                Name = name;
            }

            public string GetName()
            {
                return Name;
            }

            public abstract void Eat();
        }
    }
}
