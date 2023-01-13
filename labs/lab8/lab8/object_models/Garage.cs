using System.Collections.Generic;

namespace lab8.object_models
{
    class Garage
    {
        public List<Car> Cars { get; set; } = new List<Car>();

        public Garage(List<Car> cars)
        {
            Cars = cars;
        }



    }
}
