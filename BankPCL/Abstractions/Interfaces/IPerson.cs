using System;

using System.Collections.Generic;

using BankPCL.Abstractions.Interfaces.Strategies.Person_Strategies;

namespace BankPCL.Abstractions.Interfaces
{
    public interface IPerson
    {
        string ID { get; set; }

        string FirstName { get; set; }
        string LastName { get; set; }

        double? Salary { get; set; }
        double? Rating { get; set; }

        IPersonStateStrategy PersonStateStrategy { get; set; }

        List<ILoanRequest> Accounts { get; set; }
    }
}
