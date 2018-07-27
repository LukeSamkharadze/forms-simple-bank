using System;

namespace BankPCL.Abstractions.Interfaces
{
    public interface ILoanRequest
    {
        IAccount Account { get; set; }

        double? Amount { get; set; }
    }
}
