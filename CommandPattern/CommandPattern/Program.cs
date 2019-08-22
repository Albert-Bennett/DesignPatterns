using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IReceiver chef = new Chef();
            Command order = new Waiter(chef);
            IInvoker guest = new Guest();

            guest.SetCommand(order);
            guest.InvokeCommand();

            Console.ReadKey();
        }
    }
}
