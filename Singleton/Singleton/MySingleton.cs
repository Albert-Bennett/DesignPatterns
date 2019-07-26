using System;

namespace Singleton
{
    public class MySingleton : IMySingleton
    {
        static Lazy<MySingleton> instance = new Lazy<MySingleton>(
            () => new MySingleton());

        public static MySingleton Instance => instance.Value;

        public void DoADifferntThing()
        {
            Console.WriteLine("We did a differnt thing!!");
        }
    }
}
