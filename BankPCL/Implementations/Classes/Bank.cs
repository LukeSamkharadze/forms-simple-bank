using System;

using System.Collections.Generic;
using System.Linq;

using BankPCL.Abstractions.Interfaces;

namespace BankPCL.Implementations.Classes
{
    public class Bank : IBank
    {
        public static Bank Instance { get; set; } = new Bank();

        public double? MaxRating { get; set; } = null;
        public double? MaxLoan { get; set; } = null;

        public List<IPerson> Persons { get; set; } = new List<IPerson>();
        public Queue<ILoanRequest> LoanQueue { get; set; } = new Queue<ILoanRequest>();

        private Bank() { }

        public IAccount FindAccount(string accountID)
        {
            return Persons.FirstOrDefault(o => o.Accounts.First().ID == accountID)?.Accounts.First(o => o.ID == accountID);
        }

        public void ReceiveLoanRequest(ILoanRequest loanRequest)
        {
            LoanQueue.Enqueue(loanRequest);
        }
        public void GiveLoan(double amount,IAccount account)
        {
            account.ReceiveLoan(amount, amount * (double)account.Owner.MembershipStrategy.Interest / 100);
        }
    }
}
