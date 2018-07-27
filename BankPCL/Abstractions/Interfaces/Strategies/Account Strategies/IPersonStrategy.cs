using System;

namespace BankPCL.Abstractions.Interfaces.Strategies.Person_Strategies
{
    public interface IPersonStrategy
    {
        double? Interest { get; set; }
    }
}
