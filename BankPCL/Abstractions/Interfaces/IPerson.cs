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

        string Password { get; set; }

        double? Salary { get; set; }
        double? Rating { get; set; }

        IMembershipStrategy MembershipStrategy { get; set; }

        List<IAccount> Accounts { get; set; }
    }
}
