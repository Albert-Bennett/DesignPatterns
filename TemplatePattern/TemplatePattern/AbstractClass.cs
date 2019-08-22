using System;

namespace TemplatePattern
{
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            DoSomething();
            DoSomethingElse();
        }

        protected abstract void DoSomething();
        protected abstract void DoSomethingElse();
    }

    public class SubClass : AbstractClass
    {
        protected override void DoSomething()
        {
            Console.WriteLine("Doing something");
        }

        protected override void DoSomethingElse()
        {
            Console.WriteLine("Doing something else");
        }
    }
}
