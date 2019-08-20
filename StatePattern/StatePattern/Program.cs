using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new StateA());
            context.ChangeState();
            context.ChangeState();

            Console.ReadLine();
        }
    }
}
