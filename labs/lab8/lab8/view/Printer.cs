using lab8.object_models;
using System;
using System.Collections.Generic;

namespace lab8.view
{
    class Printer
    {
        public static void PrintList(List<Car> cars, string msg)
        {
            Console.WriteLine(msg);
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
