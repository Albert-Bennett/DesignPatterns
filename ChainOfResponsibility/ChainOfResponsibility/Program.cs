using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Chemist chemist = new Chemist();
            Electrician electrician = new Electrician();

            chemist.SetNextHandler(electrician);

            Client client = new Client(chemist);
            client.WhoIsDoingThis("chemistry");
            client.WhoIsDoingThis("electricity");
            client.WhoIsDoingThis("some other third thing");

            Console.ReadLine();
        }
    }
}
