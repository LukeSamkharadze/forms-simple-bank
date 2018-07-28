using System;

using BankPCL.Abstractions.Interfaces.Strategies.Person_Strategies;

namespace BankPCL.Implementations.Classes.Strategies.Account_Strategies
{
    public class PersontSilverStateStrategy : IPersonStateStrategy
    {
        public double? Interest { get; set; }
    }
}
