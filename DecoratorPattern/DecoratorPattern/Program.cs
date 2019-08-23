using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent wheels = new Wheels();
            Decorator chassis = new Chassis();
            chassis.SetComponent(wheels);

            Decorator carBody = new CarBody();
            carBody.SetComponent(chassis);

            carBody.Build();

            Console.ReadKey();
        }
    }
}
