using System;

namespace ChainOfResponsibility
{
    public class Client
    {
        private readonly IHandler _handler;

        public Client(IHandler handler)
        {
            _handler = handler;
        }

        public void WhoIsDoingThis(string request)
        {
            string message = _handler.Handle(request);

            Console.WriteLine(!string.IsNullOrEmpty(message) ? message : "No one can do that :(");
        }
    }
}
