using System;

namespace FacadePattern
{
    public class Facade
    {
        private readonly BankingSystem _banking;
        private readonly BillingSystem _billing;

        public Facade(BankingSystem banking, BillingSystem billing)
        {
            _banking = banking;
            _billing = billing;
        }

        public void PayBills()
        {
            Console.WriteLine("I'm paying me bills");

            _banking.SetBankBalance(100);
            int amountDue = _billing.GetBillingAmount();
            _banking.GetMoney(amountDue);
            _billing.PayBills(amountDue);

            Console.WriteLine("I've payed my bills :)");
        }
    }
}
