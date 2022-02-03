using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class VehicleInterface
    {
        public static void Main3(string[] args)
        {
            Car car = new Car(0);
            Console.Write("Enter fule value in numbers->");
            int fuel = int.Parse(Console.ReadLine());
            if (car.Refuel(fuel))
            {
                car.Drive();
            }
        }

        public interface IVehicle
        {
            void Drive();
            bool Refuel(int amount);
        }

        public class Car : IVehicle
        {
            public int Fuel { get; set; }

            public Car(int fuel)
            {
                Fuel = fuel;
            }

            public void Drive()
            {
                if (Fuel > 0)
                {
                    Console.WriteLine("Za car be driving, i.e., Za Warudo!! Toki wo tomare");
                }
                else
                {
                    Console.WriteLine("No fuel so no driving plans cancelled!!");
                }
            }

            public bool Refuel(int amount)
            {
                Fuel += amount;
                return true;
            }
        }
    }
}
