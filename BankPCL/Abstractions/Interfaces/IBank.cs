using System;

using System.Collections.Generic;

namespace BankPCL.Abstractions.Interfaces
{
    public interface IBank
    {
        double? MaxRating { get; set; }
        double? MaxLoan { get; set; }

        List<IPerson> Persons { get; set; }
        Queue<ILoanRequest> LoanQueue { get; set; }

        void ReceiveLoanRequest(ILoanRequest loanRequest);
        void GiveLoan(IAccount account, double amount);
    }
}
