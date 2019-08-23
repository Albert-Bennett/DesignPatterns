using System;

namespace DecoratorPattern
{
    public interface IComponent
    {
        void Build();
    }

    public class Wheels : IComponent
    {
        public void Build()
        {
            Console.WriteLine("Attaching the wheels");
        }
    }
}
