using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite composite = new Composite();
            Composite firstBranch = new Composite();
            firstBranch.AddComponent(new Leaf());
            firstBranch.AddComponent(new Leaf());

            composite.AddComponent(firstBranch);
            composite.AddComponent(new Leaf());

            string result = composite.Action();

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
