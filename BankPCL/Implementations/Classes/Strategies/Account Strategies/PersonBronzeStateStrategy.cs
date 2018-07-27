using System;

using BankPCL.Abstractions.Interfaces.Strategies.Person_Strategies;

namespace BankPCL.Implementations.Classes.Strategies.Account_Strategies
{
    public class PersonBronzeStateStrategy : IPersonStrategy
    {
        public double? Interest { get; set; }
    }
}
