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

        public void ReceiveSendMoneyRequest(double amount, IAccount senderAccount, string receiverAccountID)
        {
            IAccount receiver = Persons
                .FirstOrDefault(o => o.Accounts.First().ID == receiverAccountID)
                ?.Accounts.First(o => o.ID == receiverAccountID);

            if (receiver == null)
                throw new Exception("Could't Find AccountID");

            SendMoney(amount, senderAccount, receiver);
        }
        public void SendMoney(double amount,IAccount senderAccount, IAccount receiver)
        {
            IPerson senderPerson = Persons.FirstOrDefault(o => o.Accounts.Contains(senderAccount));
            senderAccount.Balance -= amount;
            receiver.ReceiveMoney(amount, senderPerson);
        }

        public IAccount FindAccount(string accountID)
        {
            return Persons.FirstOrDefault(o => o.Accounts.First().ID == accountID)?.Accounts.First(o => o.ID == accountID);
        }

        public void ReceiveLoanRequest(double amount, IAccount account)
        {
            LoanQueue.Enqueue(new LoanRequest() { Account = account, Amount = amount });
        }
        public void GiveLoan(double amount,IAccount account)
        {
            account.ReceiveLoan(amount, amount * (double)account.Owner.MembershipStrategy.Interest / 100);
        }
    }
}
