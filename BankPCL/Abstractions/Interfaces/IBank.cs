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

        void ReceiveLoanRequest(ILoanRequest loanRequest);
        void GiveLoan(double amount, IAccount account);
    }
}
