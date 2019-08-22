using System;

namespace CommandPattern
{
    public abstract class Command
    {
        public IReceiver Receiver { get; }

        protected Command(IReceiver receiver)
        {
            Receiver = receiver;
        }

        public abstract void GetOrder();
    }

    public class Waiter : Command
    {
        public Waiter(IReceiver receiver) : base(receiver) { }

        public override void GetOrder()
        {
            Console.WriteLine("Getting order...");
            Receiver.CookFood();
        }
    }
}