using Builder.AssemblyLine;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            IAssemblyLine assemblyLine = new MyAssemblyLine();
            AssemblyLineClient client = new AssemblyLineClient(assemblyLine);

            client.BuildCar();
            var car = assemblyLine.GetCar();

            Console.ReadKey();
        }
    }
}
