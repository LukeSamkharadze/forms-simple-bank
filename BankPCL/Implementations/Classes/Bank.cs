using System;

using System.Collections.Generic;
using System.Linq;

using BankPCL.Abstractions.Interfaces;
using BankPCL.Abstractions.Interfaces.Strategies;

using BankPCL.Implementations.Services;

namespace BankPCL.Implementations.Classes
{
    public class Bank : IBank
    {
        public static Bank Instance { get; set; } = new Bank();

        public double? MaxRating { get; set; } = null;
        public double? MaxLoan { get; set; } = null;

        public List<IPerson> Persons { get; set; }
        public List<IPerson> BlockedPersons { get; set; }

        public List<IMembershipStrategy> Memeberships { get; set; }
        public List<ILoanRequest> LoanRequests { get; set; }

        private Bank() { }

        public void BlockOrUnblockPerson(string personID,bool blockOrUnblock)
        {
            IPerson person = BankServices.FindPerson(personID);

            if (person == null)
                throw new Exception("Could't Find Person");

            BlockOrUnblockPerson(person, blockOrUnblock);
        }
        public void BlockOrUnblockPerson(IPerson person, bool blockOrUnblock)
        {
            person.IsBlocked = blockOrUnblock;
        }

        public void BlockOrUnblockAccount(string accountID, bool blockOrUnblock)
        {
            IAccount account = BankServices.FindAccount(accountID);

            if (account == null)
                throw new Exception("Could't Find Account");

            BlockOrUnblockAccount(account, blockOrUnblock);
        }
        public void BlockOrUnblockAccount(IAccount account, bool blockOrUnblock)
        {
            account.IsBlocked = true;
        }

        public void ReceiveSendMoneyRequest(double amount, IAccount senderAccount, string receiverAccountID)
        {
            IAccount receiver = BankServices.FindAccount(receiverAccountID);
            
            if (receiver == null)
                throw new Exception("Could't Find AccountID");
            
            SendMoney(amount, senderAccount, receiver);
        }
        public void SendMoney(double amount, IAccount senderAccount, IAccount receiver)
        {
            IPerson senderPerson = Persons.FirstOrDefault(o => o.Accounts.Contains(senderAccount));
            senderAccount.Balance -= amount;
            receiver.ReceiveMoney(amount, senderPerson);
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
