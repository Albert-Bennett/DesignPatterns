using System.Collections.Generic;

namespace ObserverPattern
{
    public interface ISubject
    {
        string Message { get; set; }

        void AddObserver(Observer observer);
        void RemoveObserver(Observer observer);
        void Notify();
    }

    public class TvShow : ISubject
    {
        readonly List<Observer> _observers = new List<Observer>();

        public string Message { get; set; }

        public void AddObserver(Observer observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
        }

        public void RemoveObserver(Observer observer)
        {
            if (_observers.Contains(observer))
            {
                _observers.Remove(observer);
            }
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}
