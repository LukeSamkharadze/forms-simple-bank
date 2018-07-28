using System;

namespace BankPCL.Abstractions.Interfaces.Strategies.Person_Strategies
{
    public interface IPersonStateStrategy
    {
        double? Interest { get; set; }
    }
}
