using System;

using BankPCL.Abstractions.Interfaces.Strategies;

namespace BankPCL.Implementations.Classes.Strategies.Membership_Strategies
{
    public class CustomMembershipStrategy : IMembershipStrategy
    {
        public double? Priority { get; set; } = null;

        public double? Interest { get; set; } = null;

        public double? MaxLoan { get; set; } = null;

        public double? UpperLimit { get; set; } = null;
        public double? LowerLimit { get; set; } = null;
    }
}
