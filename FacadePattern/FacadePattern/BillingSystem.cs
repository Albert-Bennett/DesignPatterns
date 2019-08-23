using System;

namespace FacadePattern
{
    public class BillingSystem
    {
        public int GetBillingAmount()
        {
            int amount = 15;

            Console.WriteLine($"You owe us: €{amount}, for bills and stuff");
            return amount;
        }

        public void PayBills(int amount)
        {
            Console.WriteLine($"Payed the bill for the amount: {amount}");
        }
    }

    public class BankingSystem
    {
        private int _balance;

        public void SetBankBalance(int amount)
        {
            _balance = amount;
            Console.WriteLine($"Your current balance is: €{_balance}");
        }

        public int GetMoney(int amount)
        {
            _balance -= amount;
            SetBankBalance(_balance);
            return amount;
        }
    }
}