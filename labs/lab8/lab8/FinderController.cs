using lab8.object_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class FinderController
    {
        public static List<Car> FindBySpeed(int speed, List<Car> cars)
        {
            return cars.FindAll(car => car.Speed == speed);
        }
        public static List<Car> FindByAge(int age, List<Car> cars)
        {
            return cars.FindAll(car => car.Age == age);
        }
        public static List<Car> FindByName(string name, List<Car> cars)
        {
            return cars.FindAll(car => car.Name.Equals(name));
        }
        public static List<Car> FindByColor(string color, List<Car> cars)
        {
            return cars.FindAll(car => car.Color.Equals(color));
        }
    }
}