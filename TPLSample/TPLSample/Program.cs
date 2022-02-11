using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPLSample
{
    class Program
    {
        delegate double ArithmaticDelegate(double x, double y);

        static void Menu()
        {
            Console.WriteLine("Select an arithmatic operation");
            Console.WriteLine("1)Addition");
            Console.WriteLine("2)Subtraction");
            Console.WriteLine("3)Multiplication");
            Console.WriteLine("4)Division");
            Console.WriteLine("5)Remainder");
            Console.WriteLine("6)Quit");
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            return a / b;
        }

        static double Modulus(double a, double b)
        {
            return a % b;
        }

        static void Main(string[] args)
        {
            int operation;
            ArithmaticDelegate arithmatic;
            double x, y;

            do
            {
                Console.WriteLine("Enter two numbers seperated by Enter");
                x = double.Parse(Console.ReadLine());
                y = double.Parse(Console.ReadLine());
                Console.Clear();

                Menu();
                operation = int.Parse(Console.ReadLine());

                switch (operation)
                {
                    //Addition
                    case 1:
                        arithmatic = new ArithmaticDelegate(Add);
                        break;
                    //Subtraction
                    case 2:
                        arithmatic = new ArithmaticDelegate(Subtract);
                        break;
                    //Multiplication
                    case 3:
                        arithmatic = new ArithmaticDelegate(Multiply);
                        break;
                    //Division
                    case 4:
                        arithmatic = new ArithmaticDelegate(Divide);
                        break;
                    //Remainder
                    case 5:
                        arithmatic = new ArithmaticDelegate(Modulus);
                        break;
                    default:
                        Console.WriteLine("Exiting program");
                        break;
                }
                Console.Clear();
                Console.WriteLine(arithmatic(x, y));
                Console.WriteLine("Press any key to continue");
                Console.ReadKey(true);
                Console.Clear();

            } while (operation != 6);

        }
    }
}
