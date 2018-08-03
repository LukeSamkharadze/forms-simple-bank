using System;

using System.Collections.Generic;

using BankPCL.Abstractions.Interfaces.Strategies;

namespace BankPCL.Abstractions.Interfaces
{
    public interface IBank
    {
        double? MaxRating { get; set; }

        List<IPerson> Persons { get; set; }
        List<IPerson> BlockedPersons { get; set; }

        List<IMembershipStrategy> Memeberships { get; set; }
        List<ILoanRequest> LoanRequests { get; set; }

        void BlockOrUnblockPerson(string personID, bool blockOrUnblock);
        void BlockOrUnblockPerson(IPerson person, bool blockOrUnblock);

        void BlockOrUnblockAccount(string personID, bool blockOrUnblock);
        void BlockOrUnblockAccount(IAccount account, bool blockOrUnblock);

        void ReceiveSendMoneyRequest(double amount, IAccount senderAccount, string receiverAccountID);
        void SendMoney(double amount, IAccount sender, IAccount receiver);

        void ReceiveLoanRequest(double amount, IAccount account);
        void GiveLoan(double amount, IAccount account);
    }
}
