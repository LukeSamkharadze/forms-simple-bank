using System;

using System.Linq;

using BankPCL.Abstractions.Interfaces;
using BankPCL.Implementations.Classes;

namespace BankPCL.Implementations.Services
{
    public static class BankServices
    {
        public static IPerson FindPerson(string personID)
        {
            return Bank.
                Instance
                .Persons
                .FirstOrDefault(o => o.ID == personID);
        }

        public static IAccount FindAccount(string accountID)
        {
            return Bank
                .Instance
                .Persons
                .FirstOrDefault(o => o.Accounts.FirstOrDefault().ID == accountID)
                ?.Accounts.First(o => o.ID == accountID);
        }
    }
}
