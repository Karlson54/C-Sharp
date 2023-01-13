namespace lab8.object_models
{
    class Car
    {
        public int Speed { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public Car(int speed, int age, string name, string color)
        {
            this.Speed = speed;
            this.Age = age;
            this.Name = name;
            this.Color = color;
        }
        public override string ToString()
        {
            return ($"{this.Age} {this.Speed} {this.Name} {this.Color}");
        }
    }
}
