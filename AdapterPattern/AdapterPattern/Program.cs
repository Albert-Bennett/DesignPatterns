using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Adaptee legacyCode = new Adaptee();
            Adapter adapter = new Adapter(legacyCode);

            Client client = new Client(adapter);

            Console.ReadKey();
        }
    }
}
