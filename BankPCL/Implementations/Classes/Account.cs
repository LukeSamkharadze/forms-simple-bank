using System;

using BankPCL.Abstractions.Interfaces;

namespace BankPCL.Implementations.Classes
{
    public class Account : IAccount
    {
        public IPerson Owner { get; set; } = null;

        public string ID { get; set; } = null;
        
        public double? Balance { get; set; } = null;
        public double? Loan { get; set; } = null;


        public void SendMoney(double amount,double accountID)
        {
            if (Bank.Instance.FindAccount(accountID))
            {
                Balance -= amount;
                receiver.ReceiveMoney(amount, this);
            }
        }
        public void ReceiveMoney(double amount,IAccount sender)
        {
            Balance += amount;
        }

        public void RequestLoan(double amount)
        {
            throw new Exception();
        }
        public void RecieveLoan(double amount)
        {
            throw new NotImplementedException();
        }

        public void PayLoan(double amount)
        {
            Loan -= amount;
        }
    }
}
