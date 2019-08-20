using System.Collections.Generic;

namespace IteratorPattern
{
    public interface IAggregate<T>
    {
        int Count { get; }
        T this[int index] { get; set; }

        Iterator<T> CreateIterator();
    }

    public class CarLot : IAggregate<Car>
    {
        private readonly IList<Car> _cars;

        public int Count => _cars.Count;

        public Car this[int index]
        {
            get => _cars[index];
            set => _cars.Insert(index, value);
        }

        public CarLot(Car[] cars)
        {
            _cars = cars;
        }

        public Iterator<Car> CreateIterator()
        {
            return new CarIterator(this);
        }
    }
}
