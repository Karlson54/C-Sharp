using System;
using System.Collections.Generic;
using lab8.object_models;
using lab8.view;

namespace lab8
{
    class GarageController
    {
        public static void AddCar(Car car, Garage garage)
        {
            garage.Cars.Add(car);
        }

        public static void DeleteCar(Car car, Garage garage)
        {
            garage.Cars.Remove(car);
        }

        public static void GetCar(Car findCar, Garage garage)
        {
            foreach (Car car in garage.Cars)
            {
                if (car.Equals(findCar))
                {
                    DeleteCar(car, garage);
                    Console.WriteLine($"You took {car}");
                }
            }
        }

        public static List<Car> FindBySpeed(int speed, Garage garage)
        {
            return FinderController.FindBySpeed(speed, garage.Cars);
        }
        public static List<Car> FindByAge(int age, Garage garage)
        {
            return FinderController.FindByAge(age, garage.Cars);
        }
        public static List<Car> FindByName(string name, Garage garage)
        {
            return FinderController.FindByName(name, garage.Cars);
        }
        public static List<Car> FindByColor(string color, Garage garage)
        {
            return FinderController.FindByColor(color, garage.Cars);
        }

        public static List<Car> FindByAllCharacteristics(int speed, int age, string name, string color, Garage garage)
        {
            List<Car> foundResultBySpeed = FinderController.FindBySpeed(speed, garage.Cars);
            Printer.PrintList(foundResultBySpeed, "We found ur cars by speed");
            List<Car> foundResultByAge = FinderController.FindByAge(age, foundResultBySpeed);
            Printer.PrintList(foundResultByAge, "We found ur cars by speed and age");
            List<Car> foundResultByName = FinderController.FindByName(name, foundResultByAge);
            Printer.PrintList(foundResultByName, "We found ur cars by speed and age and name");
            List<Car> foundResultByColor = FinderController.FindByColor(color, foundResultByName);
            Printer.PrintList(foundResultByColor, "We found ur cars by speed and age and name and color");
            return foundResultByColor;
        }
    }
}