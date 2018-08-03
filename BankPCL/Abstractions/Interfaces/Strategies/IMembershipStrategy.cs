using System;

namespace BankPCL.Abstractions.Interfaces.Strategies
{
    public interface IMembershipStrategy
    {
        double? Priority { get; set; }

        double? Interest { get; set; }

        double? MaxLoan { get; set; }

        double? UpperLimit { get; set; }
        double? LowerLimit { get; set; }
    }
}
