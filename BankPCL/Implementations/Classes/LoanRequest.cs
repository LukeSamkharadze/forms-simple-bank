using System;

using BankPCL.Abstractions.Interfaces;

namespace BankPCL.Implementations.Classes
{
    public class LoanRequest : ILoanRequest
    {
        public IAccount Account { get; set; } = null;

        public double? Amount { get; set; } = null;
    }
}
