using System;

namespace BridgePattern
{
    public interface IImplementor
    {
        void Speak();
    }

    public class FirstSpeaker : IImplementor
    {
        public void Speak()
        {
            Console.WriteLine("Mmmmmm......");
        }
    }

    public class SecondSpeaker : IImplementor
    {
        public void Speak()
        {
            Console.WriteLine("That will be an ecumenical matter");
        }
    }
}
