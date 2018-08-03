using System;

namespace BankPCL.Abstractions.Interfaces
{
    public interface ITransaction
    {
        IAccount FromAccount { get; set; }
        IAccount ToAccount { get; set; }

        double? amount { get; set; }
    }
}
