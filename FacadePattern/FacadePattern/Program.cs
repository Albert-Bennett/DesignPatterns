using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BankingSystem banking = new BankingSystem();
            BillingSystem billing = new BillingSystem();

            Facade facade = new Facade(banking, billing);
            facade.PayBills();

            Console.ReadKey();
        }
    }
}
