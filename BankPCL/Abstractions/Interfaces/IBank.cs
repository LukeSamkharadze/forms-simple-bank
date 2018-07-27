using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPCL.Abstractions.Interfaces
{
    public interface IBank
    {
        double? MaxRating { get; set; }
        double? MaxLoan { get; set; }

        Queue<ILoanRequest> LoanQueue { get; set; }

        void ReceiveLoanRequest(ILoanRequest loanRequest);
        void GiveLoan(IAccount account, double amount);
    }
}
