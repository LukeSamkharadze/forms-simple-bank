using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

using BankPCL.Abstractions.Interfaces;

namespace BankPCL.Implementations.Classes
{
    public class Bank : IBank
    {
        public static Random random { get; set; } = new Random();
        /////////////////////////////////////////////////////////
        public static Bank Instance { get; set; } = new Bank();

        public double? MaxRating { get; set; } = null;
        public double? MaxLoan { get; set; } = null;

        public List<IAccount> Accounts { get; set; } = new List<IAccount>();
        public Queue<ILoanRequest> LoanQueue { get; set; } = new Queue<ILoanRequest>();

        private Bank() { }

        public void ReceiveLoanRequest(ILoanRequest loanRequest)
        {
            LoanQueue.Enqueue(loanRequest);

            throw new Exception("Received Loan Request Was't Accepted");
        }

        public void GiveLoan(IAccount account, double amount)
        {
            account.RecieveLoan(amount);
        }
    }
}
