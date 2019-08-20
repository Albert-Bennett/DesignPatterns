using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new StrategyA());
            context.Execute();

            context.ChangeStrategy(new StrategyB());
            context.Execute();

            Console.ReadLine();
        }
    }
}
