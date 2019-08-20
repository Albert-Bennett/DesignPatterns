using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubject tvShow = new TvShow();
            tvShow.Message = "has ended";

            tvShow.AddObserver(new Person(tvShow, "Oh no. The tv show has {0}"));
            tvShow.AddObserver(new Person(tvShow, "It's about time that the show {0}"));
            tvShow.AddObserver(new Person(tvShow, "The show {0}!"));

            tvShow.Notify();
            Console.ReadKey();
        }
    }
}
