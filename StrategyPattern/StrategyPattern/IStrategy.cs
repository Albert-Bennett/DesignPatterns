using System;

namespace StrategyPattern
{
    public interface IStrategy
    {
        void DoSomething();
    }

    public class StrategyA : IStrategy
    {
        public void DoSomething()
        {
            Console.WriteLine("Strategy A Called");
        }
    }

    public class StrategyB : IStrategy
    {
        public void DoSomething()
        {
            Console.WriteLine("Strategy B Called");
        }
    }
}
