using lab8.object_models;
using System;
using System.Collections.Generic;

namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            

            List<Car> cars = new List<Car>()
            {
            new Car(100, 1957, "BMW", "Black"),
            new Car(100, 1968, "Chevrolet", "White"),
            new Car(50, 2010, "Scooter", "White"),
            new Car(1, 2001, "Human", "Human"),
            };

            Garage garage = new Garage(cars);

            GarageController.FindByAllCharacteristics(100, 1968, "Chevrolet", "White", garage);

            Console.ReadKey();
        }
    }
}
