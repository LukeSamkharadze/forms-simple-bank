using System;

using BankPCL.Abstractions.Interfaces;

namespace BankPCL.Implementations.Classes
{
    public class Transaction : ITransaction
    {
        public IAccount FromAccount { get; set; }
        public IAccount ToAccount { get; set; }

        public double? amount { get; set; }
    }
}
