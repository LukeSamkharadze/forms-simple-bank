using System;
using System.Collections.Generic;

namespace BankPCL.Abstractions.Interfaces
{
    public interface IAccount
    {
        IPerson Owner { get; set; }

        string ID { get; set; }
        
        double? Balance { get; set; }
        double? Loan { get; set; }
        
        void SendMoney(double amount, string accountID);
        void ReceiveMoney(double amount, IAccount sender);

        void RequestLoan(double amount);
        void RecieveLoan(double amount, double interest);

        void PayLoan(double amount);
    }
}
