using System;
using System.Collections.Generic;

namespace BankPCL.Abstractions.Interfaces
{
    public interface IAccount
    {
        IPerson Owner { get; set; }

        bool IsBlocked { get; set; }

        string ID { get; set; }
        
        double? Balance { get; set; }
        double? Loan { get; set; }

        event EventHandler ReceiveMoneyListeners;
        event EventHandler ReceiveLoanListeners;

        void RequestSendMoney(double amount, string accountID);
        void ReceiveMoney(double amount, IPerson sender);

        void RequestLoan(double amount);
        void ReceiveLoan(double amount, double interest);

        void PayLoan(double amount);
    }
}
