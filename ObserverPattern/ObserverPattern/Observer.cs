using System;

namespace ObserverPattern
{
    public abstract class Observer
    {
        internal ISubject Subject;

        protected Observer(ISubject subject)
        {
            Subject = subject;
        }

        public abstract void Update();
    }

    public class Person : Observer
    {
        private readonly string _message;

        public Person(ISubject subject, string message) : base(subject)
        {
            _message = message;
        }

        public override void Update()
        {
            Console.WriteLine(_message, Subject.Message);
        }
    }
}