using System;

using System.Collections.Generic;

namespace BankPCL.Abstractions.Interfaces
{
    public interface IBank
    {
        double? MaxRating { get; set; }

        List<IPerson> Persons { get; set; }
        Queue<ILoanRequest> LoanQueue { get; set; }

        IAccount FindAccount(string accountID);

        void ReceiveSendMoneyRequest(double amount, IAccount senderAccount, string receiverAccountID)
        void SendMoney(double amount, IAccount sender, IAccount receiver);

        void ReceiveLoanRequest(double amount, IAccount account);
        void GiveLoan(double amount, IAccount account);
    }
}
