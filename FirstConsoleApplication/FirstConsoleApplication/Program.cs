using System;

namespace FirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            Console.WriteLine("Enter 2 nos");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter choice of operation,1 is for addition, 2 is for subtraction, 3 is for multiplication, 4 is for division");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    c = a + b;
                    break;
                case 2:
                    c = a - b;
                    break;
                case 3:
                    c = a * b;
                    break;
                case 4:
                    c = a / b;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            Console.WriteLine(c);
        }
    }
}
