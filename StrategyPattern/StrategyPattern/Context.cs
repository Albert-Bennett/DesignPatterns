namespace StrategyPattern
{
    public class Context
    {
        private IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Execute()
        {
            _strategy.DoSomething();
        }

        public void ChangeStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }
    }
}
