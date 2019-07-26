using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //I bet that you thought that I had forgotten about showing it working.
            MySingleton.Instance.DoADifferntThing();
            Console.ReadLine();
        }
    }
}
