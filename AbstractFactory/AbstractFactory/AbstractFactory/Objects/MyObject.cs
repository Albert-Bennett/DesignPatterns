using System;

namespace AbstractFactory.Objects
{
    public class MyObject : IMyObject
    {
        public void DoAThing()
        {
            Console.WriteLine("We did a thing!!");
        }
    }
}
