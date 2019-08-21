using System;

namespace AdapterPattern
{
    public class Client
    {
        private ITarget _target;

        public Client(ITarget target)
        {
            this._target = target;
            Console.WriteLine(_target.GetNumber());
        }
    }
}
