using System;

using BankPCL.Abstractions.Interfaces;

namespace BankPCL.Implementations.Classes
{
    public class Account : IAccount
    {
        public IPerson Owner { get; set; } = null;

        public string ID { get; set; } = null;

        public bool? IsBlocked { get; set; } = null;

        public double? Balance { get; set; } = null;
        public double? Loan { get; set; } = null;

        public event EventHandler ReceiveMoneyListeners;
        public event EventHandler ReceiveLoanListeners;

        public void RequestSendMoney(double amount, string accountID)
        {
            if (Balance >= amount)
                Bank.Instance.ReceiveSendMoneyRequest(amount, this, accountID);
        }
        public void ReceiveMoney(double amount,IPerson sender)
        {
            Balance += amount;
        }

        public void RequestLoan(double amount)
        {
            Bank.Instance.ReceiveLoanRequest(amount, this);
        }
        public void ReceiveLoan(double amount, double interest)
        {
            Balance += amount;
            Loan += amount + interest;
        }

        public void PayLoan(double amount)
        {
            Loan -= amount;
        }
    }
}
