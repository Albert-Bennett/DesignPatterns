using System;

namespace CommandPattern
{
    public interface IReceiver
    {
        void CookFood();
    }

    public class Chef : IReceiver
    {
        public void CookFood()
        {
            Console.WriteLine("Cooking food!!");
        }
    }
}
