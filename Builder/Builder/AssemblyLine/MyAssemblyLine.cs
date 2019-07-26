using Builder.Cars;

namespace Builder.AssemblyLine
{
    public class MyAssemblyLine : IAssemblyLine
    {
        Car car;

        public MyAssemblyLine()
        {
            car = new Car();
        }

        public Car GetCar()
        {
            var carToReturn = car;
            car = new Car();

            return carToReturn;
        }

        public IAssemblyLine SetName()
        {
            car.Name = "Not a real car name";
            return this;
        }

        public IAssemblyLine MakeMake()
        {
            car.Make = CarMakes.Fjord;
            return this;
        }

        public IAssemblyLine PaintCar()
        {
            car.Colour = CarColours.Brorange;
            return this;
        }
    }
}
