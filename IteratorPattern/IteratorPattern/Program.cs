using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = {
                new Car("Mercades"),
                new Car("Pluto"),
                new Car("Red car"),
                new Car("Lamborgoti"),
            };

            CarLot carLot = new CarLot(cars);
            var iterator = carLot.CreateIterator();

            Console.WriteLine(iterator.CurrentItem().CarType);

            while (!iterator.Done)
            {
                Console.WriteLine(iterator.Next().CarType);
            }

            Console.ReadKey();
        }
    }
}
