using AbstractFactory.Factory;
using AbstractFactory.Objects;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IMyFactory myFactory = 
                new MyFactory();

            TestFactory(myFactory);

            Console.ReadKey();
        }

        static void TestFactory(IMyFactory factory)
        {
            IMyObject createdObject = factory.CreateInstance();
            createdObject.DoAThing();
        }
    }
}