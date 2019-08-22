using System;

namespace CommandPattern
{
    public interface IInvoker
    {
        void SetCommand(Command command);
        void InvokeCommand();
    }

    public class Guest : IInvoker
    {
        private Command _command;

        public void SetCommand(Command command)
        {
            _command = command;
        }

        public void InvokeCommand()
        {
            Console.WriteLine("Sending order...");

            _command?.GetOrder();
        }
    }
}
