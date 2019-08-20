using System;

namespace InterpreterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IClient client = new Client();
            client.Execute();

            Console.ReadKey();
        }
    }
}
