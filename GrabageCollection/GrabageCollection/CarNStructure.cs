using System;
using System.Collections.Generic;
using System.Text;

namespace GrabageCollection
{
    class CarNStructure
    {
    struct Car
        {
            public string Model;
            public int YOP;
        }

        static void Main3(string[] args)
        {
            int tot = 3;
            Car[] cars = new Car[tot];

            for (int i = 0; i < tot; i++)
            {
                cars[i] = new Car()
                {
                    Model = Console.ReadLine(),
                    YOP = int.Parse(Console.ReadLine())
                };
            }
            for (int i = 0; i < tot - 1; i++)
            {
                for (int j = i + 1; j < tot; j++)
                {
                    if (cars[i].YOP > cars[j].YOP)
                    {
                        var aux = cars[i];

                        cars[i] = cars[j];
                        cars[j] = aux;
                    }
                }
            }
            for (int i = 0; i < tot; i++)
            {
                var car = cars[i];
                Console.WriteLine("Model: " + car.Model + ", " +
                    "Year of production: " + car.YOP);
            }
        }
    }
}
