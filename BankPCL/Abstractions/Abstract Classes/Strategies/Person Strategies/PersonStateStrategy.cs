using System;

using BankPCL.Abstractions.Interfaces.Strategies.Person_Strategies;

namespace BankPCL.Abstractions.Abstract_Classes.Strategies.Person_Strategies
{
    public abstract class PersonStateStrategy : IPersonStateStrategy
    {
        public virtual double? Priority { get; set; }

        public virtual double? Interest { get; set; }

        public virtual double? UpperLimit { get; set; }
        public virtual double? LowerLimit { get; set; }
    }
}
