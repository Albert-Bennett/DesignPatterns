namespace IteratorPattern
{
    public abstract class Iterator<T>
    {
        internal IAggregate<T> Aggregator { get; }

        public int CurrentIndex { get; internal set; } = 0;
        public bool Done => CurrentIndex >= Aggregator.Count - 1;

        protected Iterator(IAggregate<T> aggregator)
        {
            Aggregator = aggregator;
        }

        public abstract T First();
        public abstract T CurrentItem();
        public abstract T Next();
    }

    public class CarIterator : Iterator<Car>
    {
        public CarIterator(IAggregate<Car> aggregator) : base(aggregator) { }

        public override Car First()
        {
            return Aggregator[0];
        }

        public override Car CurrentItem()
        {
            return Aggregator[CurrentIndex];
        }

        public override Car Next()
        {
            if (CurrentIndex < Aggregator.Count)
            {
                CurrentIndex++;
                return Aggregator[CurrentIndex];
            }

            return null;
        }
    }
}