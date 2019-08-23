using System;

namespace DecoratorPattern
{
    public abstract class Decorator : IComponent
    {
        protected IComponent Component { get; private set; }

        public void SetComponent(IComponent component)
        {
            Component = component;
        }

        public virtual void Build()
        {
            Component?.Build();
        }
    }

    public class Chassis : Decorator
    {
        public override void Build()
        {
            Console.WriteLine("Building the Chassis");
            base.Build();
        }
    }

    public class CarBody : Decorator
    {
        public override void Build()
        {
            Console.WriteLine("Building the body of the car");
            base.Build();
        }
    }
}