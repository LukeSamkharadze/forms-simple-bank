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


        public void SendMoney(IAccount receiver, double amount)
        {
            Balance -= amount;
            receiver.ReceiveMoney(this, amount);
        }
        public void ReceiveMoney(IAccount sender, double amount)
        {
            Balance += amount;
        }

        

        public void PayLoan(double amount)
        {
            Loan -= amount;
        }

        public void RequestLoan(double amount)
        {
            throw new Exception();
        }

        public void RecieveLoan(double amount)
        {
            throw new NotImplementedException();
        }
    }
}
