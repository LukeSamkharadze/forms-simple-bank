using System;

using BankPCL.Abstractions.Interfaces.Strategies.Person_Strategies;

namespace BankPCL.Abstractions.Abstract_Classes.Strategies.Person_Strategies
{
    public abstract class PersonStateStrategy : IPersonStrategy
    {
        public virtual double? Interest { get; set; }
    }
}
